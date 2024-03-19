using Newtonsoft.Json;

namespace SEPValidation.Model.VClaim20
{
    public class SEPCreate
    {
        public class Cob
        {
            [JsonProperty("cob")]
            public string? cob { get; set; }
        }

        public class Jaminan
        {
            [JsonProperty("lakaLantas")]
            public string? lakaLantas { get; set; }

            [JsonProperty("noLP")]
            public string? noLP { get; set; }

            [JsonProperty("penjamin")]
            public Penjamin? penjamin { get; set; }
        }

        public class Katarak
        {
            [JsonProperty("katarak")]
            public string? katarak { get; set; }
        }

        public class KlsRawat
        {
            [JsonProperty("klsRawatHak")]
            public string? klsRawatHak { get; set; }

            [JsonProperty("klsRawatNaik")]
            public string? klsRawatNaik { get; set; }

            [JsonProperty("pembiayaan")]
            public string? pembiayaan { get; set; }

            [JsonProperty("penanggungJawab")]
            public string? penanggungJawab { get; set; }
        }

        public class LokasiLaka
        {
            [JsonProperty("kdPropinsi")]
            public string? kdPropinsi { get; set; }

            [JsonProperty("kdKabupaten")]
            public string? kdKabupaten { get; set; }

            [JsonProperty("kdKecamatan")]
            public string? kdKecamatan { get; set; }
        }

        public class Penjamin
        {
            [JsonProperty("tglKejadian")]
            public string? tglKejadian { get; set; }

            [JsonProperty("keterangan")]
            public string? keterangan { get; set; }

            [JsonProperty("suplesi")]
            public Suplesi? suplesi { get; set; }
        }

        public class Poli
        {
            [JsonProperty("tujuan")]
            public string? tujuan { get; set; }

            [JsonProperty("eksekutif")]
            public string? eksekutif { get; set; }
        }

        public class Request
        {
            [JsonProperty("t_sep")]
            public TSep? t_sep { get; set; }
        }

        public class Root
        {
            [JsonProperty("request")]
            public Request? request { get; set; }
        }

        public class Rujukan
        {
            [JsonProperty("asalRujukan")]
            public string? asalRujukan { get; set; }

            [JsonProperty("tglRujukan")]
            public string? tglRujukan { get; set; }

            [JsonProperty("noRujukan")]
            public string? noRujukan { get; set; }

            [JsonProperty("ppkRujukan")]
            public string? ppkRujukan { get; set; }
        }

        public class Skdp
        {
            [JsonProperty("noSurat")]
            public string? noSurat { get; set; }

            [JsonProperty("kodeDPJP")]
            public string? kodeDPJP { get; set; }
        }

        public class Suplesi
        {
            [JsonProperty("suplesi")]
            public string? suplesi { get; set; }

            [JsonProperty("noSepSuplesi")]
            public string? noSepSuplesi { get; set; }

            [JsonProperty("lokasiLaka")]
            public LokasiLaka? lokasiLaka { get; set; }
        }

        public class TSep
        {
            [JsonProperty("noKartu")]
            public string? noKartu { get; set; }

            [JsonProperty("tglSep")]
            public string? tglSep { get; set; }

            [JsonProperty("ppkPelayanan")]
            public string? ppkPelayanan { get; set; }

            [JsonProperty("jnsPelayanan")]
            public string? jnsPelayanan { get; set; }

            [JsonProperty("klsRawat")]
            public KlsRawat? klsRawat { get; set; }

            [JsonProperty("noMR")]
            public string? noMR { get; set; }

            [JsonProperty("rujukan")]
            public Rujukan? rujukan { get; set; }

            [JsonProperty("catatan")]
            public string? catatan { get; set; }

            [JsonProperty("diagAwal")]
            public string? diagAwal { get; set; }

            [JsonProperty("poli")]
            public Poli? poli { get; set; }

            [JsonProperty("cob")]
            public Cob? cob { get; set; }

            [JsonProperty("katarak")]
            public Katarak? katarak { get; set; }

            [JsonProperty("jaminan")]
            public Jaminan? jaminan { get; set; }

            [JsonProperty("tujuanKunj")]
            public string? tujuanKunj { get; set; }

            [JsonProperty("flagProcedure")]
            public string? flagProcedure { get; set; }

            [JsonProperty("kdPenunjang")]
            public string? kdPenunjang { get; set; }

            [JsonProperty("assesmentPel")]
            public string? assesmentPel { get; set; }

            [JsonProperty("skdp")]
            public Skdp? skdp { get; set; }

            [JsonProperty("dpjpLayan")]
            public string? dpjpLayan { get; set; }

            [JsonProperty("noTelp")]
            public string? noTelp { get; set; }

            [JsonProperty("user")]
            public string? user { get; set; }
        }
    }

    public class SEPCreateResponse
    {
        public class MetaData
        {
            [JsonProperty("isValid")]
            public bool? isValid { get; set; }

            [JsonProperty("code")]
            public string? code { get; set; }

            [JsonProperty("message")]
            public string? message { get; set; }
        }

        public class Root
        {
            [JsonProperty("metaData")]
            public MetaData? metaData { get; set; }

            [JsonProperty("response")]
            public object? response { get; set; }
        }
    }
}
