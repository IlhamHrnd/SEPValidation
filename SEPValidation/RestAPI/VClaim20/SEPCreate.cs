using Newtonsoft.Json;
using RestSharp;
using SEPValidation.Helper;
using SEPValidation.Model.VClaim20;

namespace SEPValidation.RestAPI.VClaim20
{
    public class SEPCreate
    {
        private const string SEPCreateEndPoint = "https://88.88.8.88/pendol2/api/Vclaim20/SepCreate";

        public static async Task<SEPCreateResponse.Root> SEPCreateNew(Model.VClaim20.SEPCreate.Root post)
        {
            SEPCreateResponse.Root sep = new SEPCreateResponse.Root();
            string url = string.Format(SEPCreateEndPoint);
            var client = new RestClient(url);
            var request = new RestRequest
            {
                Method = Method.Post,
                Timeout = ItemDefaultValue.TimeOut
            };
            var body = new Model.VClaim20.SEPCreate.Root
            {
                request = new Model.VClaim20.SEPCreate.Request
                {
                    t_sep = new Model.VClaim20.SEPCreate.TSep
                    {
                        noKartu = post.request.t_sep.noKartu,
                        tglSep = post.request.t_sep.tglSep,
                        ppkPelayanan = post.request.t_sep.ppkPelayanan,
                        jnsPelayanan = post.request.t_sep.jnsPelayanan,
                        klsRawat = post.request.t_sep.klsRawat,
                        noMR = post.request.t_sep.noMR,
                        rujukan = new Model.VClaim20.SEPCreate.Rujukan
                        {
                            asalRujukan = post.request.t_sep.rujukan.asalRujukan,
                            tglRujukan = post.request.t_sep.rujukan.tglRujukan,
                            noRujukan = post.request.t_sep.rujukan.noRujukan,
                            ppkRujukan = post.request.t_sep.rujukan.ppkRujukan
                        },
                        catatan = post.request.t_sep.catatan,
                        diagAwal = post.request.t_sep.diagAwal,
                        poli = new Model.VClaim20.SEPCreate.Poli
                        {
                            tujuan = post.request.t_sep.poli.tujuan,
                            eksekutif = post.request.t_sep.poli.eksekutif
                        },
                        cob = new Model.VClaim20.SEPCreate.Cob
                        {
                            cob = post.request.t_sep.cob.cob
                        },
                        katarak = new Model.VClaim20.SEPCreate.Katarak
                        {
                            katarak = post.request.t_sep.katarak.katarak
                        },
                        jaminan = new Model.VClaim20.SEPCreate.Jaminan
                        {
                            lakaLantas = post.request.t_sep.jaminan.lakaLantas,
                            noLP = post.request.t_sep.jaminan.noLP,
                            penjamin = post.request.t_sep.jaminan.penjamin
                        },
                        tujuanKunj = post.request.t_sep.tujuanKunj,
                        flagProcedure = post.request.t_sep.flagProcedure,
                        kdPenunjang = post.request.t_sep.kdPenunjang,
                        assesmentPel = post.request.t_sep.assesmentPel,
                        skdp = new Model.VClaim20.SEPCreate.Skdp
                        {
                            noSurat = post.request.t_sep.skdp.noSurat,
                            kodeDPJP = post.request.t_sep.skdp.kodeDPJP
                        },
                        dpjpLayan = post.request.t_sep.dpjpLayan,
                        noTelp = post.request.t_sep.noTelp,
                        user = post.request.t_sep.user
                    }
                }
            };
            request.AddJsonBody(body);
            var response = await client.ExecutePostAsync(request);

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content;
                    var data = JsonConvert.DeserializeObject<SEPCreateResponse.Root>(content);
                    sep = data;
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

            return sep;
        }
    }
}
