namespace EfiBankApiIntegration.Requests
{
    public class Shipping
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
