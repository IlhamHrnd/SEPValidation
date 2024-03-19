using Newtonsoft.Json;
using RestSharp;
using SEPValidation.Helper;
using static SEPValidation.Model.VClaim20.GetDataHistoriPelayananPeserta;

namespace SEPValidation.RestAPI.VClaim20
{
    public class GetDataHistoriPelayananPeserta
    {
        private const string PostPatientHistoryEndPoint = "http://88.88.8.88/pendol2/api/Vclaim20/GetDataHistoriPelayananPeserta";

        public static async Task<PatientHistoryRoot> PostPatientHistory(string? guarantorNo, string? startDate, string? endDate)
        {
            PatientHistoryRoot root = new PatientHistoryRoot();
            string url = string.Format(PostPatientHistoryEndPoint);
            var client = new RestClient(url);
            var request = new RestRequest
            {
                Method = Method.Post,
                Timeout = ItemDefaultValue.TimeOut
            };
            request.AddParameter("nokartu", guarantorNo);
            request.AddParameter("startdate", startDate);
            request.AddParameter("enddate", endDate);
            var response = await client.ExecutePostAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content;
                    root = JsonConvert.DeserializeObject<PatientHistoryRoot>(content);
                }
                else
                {
                    Console.WriteLine(response.StatusCode);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return root;
        }
    }
}
