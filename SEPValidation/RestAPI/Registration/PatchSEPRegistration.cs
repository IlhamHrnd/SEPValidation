using Newtonsoft.Json;
using RestSharp;
using SEPValidation.Helper;

namespace SEPValidation.RestAPI.Registration
{
    public class PatchSEPRegistration
    {
        private const string PatchSEPRegistrationEndPoint = "https://localhost:7214/Registration/PatchSEPRegistration";

        public static async Task<string> PatchSEPRegistrationNo(Model.Registration.PatchSEPRegistration patch)
        {
            string url = string.Format(PatchSEPRegistrationEndPoint);
            var client = new RestClient(url);
            var request = new RestRequest
            {
                Method = Method.Patch,
                Timeout = ItemDefaultValue.TimeOut
            };
            var body = new Model.Registration.PatchSEPRegistration
            {
                registrationNo = patch.registrationNo,
                bpjsSepNo = patch.bpjsSepNo,
                lastUpdateDateTime = patch.lastUpdateDateTime,
                lastUpdateByUserID = patch.lastUpdateByUserID
            };
            request.AddJsonBody(body);
            var response = await client.ExecuteAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content;
                    var root = JsonConvert.DeserializeObject<string>(content);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            var format = response.Content.Substring(1, response.Content.Length - 2);

            return format;
        }
    }
}
