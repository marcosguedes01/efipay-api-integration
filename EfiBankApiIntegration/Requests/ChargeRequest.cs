namespace EfiBankApiIntegration.Requests
{
    public abstract class ChargeRequest : IChargeRequest
    {
        [JsonProperty("items")]
        public List<ChargeItem> Items { get; set; }

        [JsonProperty("shippings")]
        public List<Shipping> Shippings { get; set; }
    }
}