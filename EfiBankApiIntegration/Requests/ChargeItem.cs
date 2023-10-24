namespace EfiBankApiIntegration.Requests
{
    public class ChargeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }
    }
}
