using Newtonsoft.Json;

namespace SEPValidation.Model.VClaim20
{
    public class GetDataHistoriPelayananPeserta
    {
        public class Histori
        {
            [JsonProperty("diagnosa")]
            public string? diagnosa { get; set; }

            [JsonProperty("jnsPelayanan")]
            public string? jnsPelayanan { get; set; }

            [JsonProperty("kelasRawat")]
            public string? kelasRawat { get; set; }

            [JsonProperty("namaPeserta")]
            public string? namaPeserta { get; set; }

            [JsonProperty("noKartu")]
            public string? noKartu { get; set; }

            [JsonProperty("noSep")]
            public string? noSep { get; set; }

            [JsonProperty("noRujukan")]
            public string? noRujukan { get; set; }

            [JsonProperty("poli")]
            public string? poli { get; set; }

            [JsonProperty("ppkPelayanan")]
            public string? ppkPelayanan { get; set; }

            [JsonProperty("tglPlgSep")]
            public string? tglPlgSep { get; set; }

            [JsonProperty("tglSep")]
            public string? tglSep { get; set; }
        }

        public class MetaData
        {
            [JsonProperty("isValid")]
            public bool? isValid { get; set; }

            [JsonProperty("code")]
            public string? code { get; set; }

            [JsonProperty("message")]
            public string? message { get; set; }
        }

        public class Response
        {
            [JsonProperty("histori")]
            public List<Histori>? histori { get; set; }
        }

        public class PatientHistoryRoot
        {
            [JsonProperty("metaData")]
            public MetaData? metaData { get; set; }

            [JsonProperty("response")]
            public Response? response { get; set; }
        }
    }
}
