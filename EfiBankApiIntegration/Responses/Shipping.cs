namespace EfiBankApiIntegration.Responses
{
    public class Shipping
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("payee_code")]
        public string PayeeCode { get; set; }
    }
}
