namespace EfiBankApiIntegration.Requests
{
    public sealed class BilletConfiguration
    {
        [JsonProperty("fine")]
        public int Fine { get; set; }
        
        [JsonProperty("interest")]
        public int Interest { get; set; }
    }
}
