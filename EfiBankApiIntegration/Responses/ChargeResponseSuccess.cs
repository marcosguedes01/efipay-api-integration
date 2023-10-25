namespace EfiBankApiIntegration.Responses
{
    public class ChargeResponseSuccess : IChargeResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public ChargeData Data { get; set; }
    }
}