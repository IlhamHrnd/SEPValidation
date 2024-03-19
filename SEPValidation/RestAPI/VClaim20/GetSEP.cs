using Newtonsoft.Json;
using RestSharp;
using SEPValidation.Helper;
using static SEPValidation.Model.VClaim20.GetSEP;

namespace SEPValidation.RestAPI.VClaim20
{
    public class GetSEP
    {
        private const string VClaimSEPEndPoint = "http://88.88.8.88/pendol2/api/Vclaim20/GetSep";

        public static async Task<VClaimSEPRoot> VClaimSEPValidation(string noSEP)
        {
            VClaimSEPRoot root = new VClaimSEPRoot();
            string url = string.Format(VClaimSEPEndPoint);
            var client = new RestClient(url);
            var request = new RestRequest
            {
                Method = Method.Post,
                Timeout = ItemDefaultValue.TimeOut
            };
            request.AddParameter("nosep", noSEP);
            var response = await client.ExecutePostAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content;
                    var post = JsonConvert.DeserializeObject<VClaimSEPRoot>(content);
                    root = post;
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
