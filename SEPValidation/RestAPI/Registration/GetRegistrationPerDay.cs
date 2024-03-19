using Newtonsoft.Json;
using RestSharp;
using SEPValidation.Helper;
using static SEPValidation.Model.Registration.GetRegistrationPerDay;

namespace SEPValidation.RestAPI.Registration
{
    public class GetRegistrationPerDay
    {
        private const string RegistrationPerDayEndPoint = "https://localhost:7214/Registration/GetRegistrationPerDay?StartDate={0}&EndDate={1}&IsVoid={2}";

        public static async Task<List<RegistrationRoot>> RegistrationPerDay(DateTime startDate, DateTime endDate, bool isVoid)
        {
            List<RegistrationRoot> root = new List<RegistrationRoot>();
            string url = string.Format(RegistrationPerDayEndPoint, startDate, endDate, isVoid);
            var client = new RestClient(url);
            var request = new RestRequest
            {
                Method = Method.Get,
                Timeout = ItemDefaultValue.TimeOut
            };
            var response = await client.ExecuteGetAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content;
                    var get = JsonConvert.DeserializeObject<List<RegistrationRoot>>(content);
                    root = get;
                }
                else
                {
                    Console.WriteLine(response.ErrorMessage);
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
