using RestSharp;

namespace SEPValidation.RestAPI
{
    public class BPJS
    {
        //private const string _consKey = "1679";
        //private const string _salt = "tarak123";
        //private const string _url = "https://apijkn.bpjs-kesehatan.go.id/vclaim-rest/";
        //private const string GetDataHistoriPelayananPesertaEndPoint = "https://apijkn.bpjs-kesehatan.go.id/vclaim-rest/monitoring/HistoriPelayanan/NoKartu/0001445973748/tglMulai/2023-12-06/tglAkhir/2024-03-04";
        //public static async Task<string> GetDataHistoriPelayananPeserta()
        //{
        //    var timeStamp = Helper.Helper.GetUnixTimeStamp();
        //    string result;
        //    string url = string.Format(GetDataHistoriPelayananPesertaEndPoint);
        //    var client = new RestClient(url);
        //    var request = new RestRequest
        //    {
        //        Method = Method.Get,
        //        Timeout = 10000
        //    };
        //    request.AddHeader("X-cons-id", "1679");
        //    request.AddHeader("X-timestamp", timeStamp);
        //    request.AddHeader("X-signature", Helper.Helper.GetEncodedKey(timeStamp, _consKey, _salt, false));
        //    request.AddHeader("user_key", "c1b182ca0a61895c3535d85a4f31718e");

        //    var response = await client.ExecuteGetAsync(request);

        //    try
        //    {
        //        if (response.IsSuccessful)
        //        {
        //            var content = response.Content.Trim();
        //            result = content;
        //        }
        //        else
        //        {
        //            result = response.StatusDescription;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        result = e.Message;
        //    }

        //    return result;
        //}
    }
}
