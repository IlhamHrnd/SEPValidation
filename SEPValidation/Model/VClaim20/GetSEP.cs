using Newtonsoft.Json;

namespace SEPValidation.Model.VClaim20
{
    public class GetSEP
    {
        public class Dpjp
        {
            [JsonProperty("kdDPJP")]
            public string? kdDPJP { get; set; }

            [JsonProperty("nmDPJP")]
            public string? nmDPJP { get; set; }
        }

        public class KlsRawat
        {
            [JsonProperty("klsRawatHak")]
            public string? klsRawatHak { get; set; }

            [JsonProperty("klsRawatNaik")]
            public object? klsRawatNaik { get; set; }

            [JsonProperty("pembiayaan")]
            public object? pembiayaan { get; set; }

            [JsonProperty("penanggungJawab")]
            public object? penanggungJawab { get; set; }
        }

        public class Kontrol
        {
            [JsonProperty("kdDokter")]
            public object? kdDokter { get; set; }

            [JsonProperty("nmDokter")]
            public object? nmDokter { get; set; }

            [JsonProperty("noSurat")]
            public object? noSurat { get; set; }
        }

        public class LokasiKejadian
        {
            [JsonProperty("kdKab")]
            public object? kdKab { get; set; }

            [JsonProperty("kdKec")]
            public object? kdKec { get; set; }

            [JsonProperty("kdProp")]
            public object? kdProp { get; set; }

            [JsonProperty("ketKejadian")]
            public object? ketKejadian { get; set; }

            [JsonProperty("lokasi")]
            public object? lokasi { get; set; }

            [JsonProperty("tglKejadian")]
            public object? tglKejadian { get; set; }
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

        public class Peserta
        {
            [JsonProperty("asuransi")]
            public object? asuransi { get; set; }

            [JsonProperty("hakKelas")]
            public string? hakKelas { get; set; }

            [JsonProperty("jnsPeserta")]
            public string? jnsPeserta { get; set; }

            [JsonProperty("kelamin")]
            public string? kelamin { get; set; }

            [JsonProperty("nama")]
            public string? nama { get; set; }

            [JsonProperty("noKartu")]
            public string? noKartu { get; set; }

            [JsonProperty("noMr")]
            public string? noMr { get; set; }

            [JsonProperty("tglLahir")]
            public string? tglLahir { get; set; }
        }

        public class Response
        {
            [JsonProperty("noSep")]
            public string? noSep { get; set; }

            [JsonProperty("tglSep")]
            public string? tglSep { get; set; }

            [JsonProperty("jnsPelayanan")]
            public string? jnsPelayanan { get; set; }

            [JsonProperty("kelasRawat")]
            public string? kelasRawat { get; set; }

            [JsonProperty("diagnosa")]
            public string? diagnosa { get; set; }

            [JsonProperty("noRujukan")]
            public string? noRujukan { get; set; }

            [JsonProperty("poli")]
            public string? poli { get; set; }

            [JsonProperty("poliEksekutif")]
            public string? poliEksekutif { get; set; }

            [JsonProperty("catatan")]
            public string? catatan { get; set; }

            [JsonProperty("penjamin")]
            public object? penjamin { get; set; }

            [JsonProperty("kdStatusKecelakaan")]
            public string? kdStatusKecelakaan { get; set; }

            [JsonProperty("nmstatusKecelakaan")]
            public string? nmstatusKecelakaan { get; set; }

            [JsonProperty("lokasiKejadian")]
            public LokasiKejadian? lokasiKejadian { get; set; }

            [JsonProperty("dpjp")]
            public Dpjp? dpjp { get; set; }

            [JsonProperty("peserta")]
            public Peserta? peserta { get; set; }

            [JsonProperty("klsRawat")]
            public KlsRawat? klsRawat { get; set; }

            [JsonProperty("kontrol")]
            public Kontrol? kontrol { get; set; }

            [JsonProperty("cob")]
            public string? cob { get; set; }

            [JsonProperty("katarak")]
            public string? katarak { get; set; }
        }

        public class VClaimSEPRoot
        {
            [JsonProperty("metaData")]
            public MetaData? metaData { get; set; }

            [JsonProperty("response")]
            public Response? response { get; set; }
        }
    }
}
