namespace EfiBankApiIntegration.Responses
{
    public sealed class BilletConfigurationResponse
    {
        [JsonProperty("interest")]
        public int Interest { get; set; }

        [JsonProperty("fine")]
        public int Fine { get; set; }
    }
}
