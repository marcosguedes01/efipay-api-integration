namespace EfiBankApiIntegration.Requests
{
    public sealed class BilletConfiguration
    {
        [JsonProperty("fine")]
        public int Fine { get; set; }
        
        [JsonProperty("interest")]
        public int interest { get; set; }
    }
}
