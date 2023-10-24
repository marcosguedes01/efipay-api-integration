namespace EfiBankApiIntegration.Responses
{
    public class ChargeResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public ChargeData Data { get; set; }
    }
}