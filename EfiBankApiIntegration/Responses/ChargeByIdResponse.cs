namespace EfiBankApiIntegration.Responses
{
    public class ChargeByIdResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public ChargeByIdData Data { get; set; }
    }
}