using Newtonsoft.Json;

namespace Reloadly.Airtime.Dto.Request
{
    public class MNPLookupRequest
    {
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }


        public MNPLookupRequest(string countryCode, string phone)
        {
            CountryCode = countryCode;
            Phone = phone;
        }
    }
}
