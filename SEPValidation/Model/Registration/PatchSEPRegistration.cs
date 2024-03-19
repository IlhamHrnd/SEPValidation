using Newtonsoft.Json;

namespace SEPValidation.Model.Registration
{
    public class PatchSEPRegistration
    {
        [JsonProperty("registrationNo")]
        public string? registrationNo { get; set; }

        [JsonProperty("bpjsSepNo")]
        public string? bpjsSepNo { get; set; }

        [JsonProperty("lastUpdateDateTime")]
        public DateTime? lastUpdateDateTime { get; set; }

        [JsonProperty("lastUpdateByUserID")]
        public string? lastUpdateByUserID { get; set; }
    }
}
