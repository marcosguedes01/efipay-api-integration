namespace EfiBankApiIntegration.Responses
{
    public class Item
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }
    }
}
