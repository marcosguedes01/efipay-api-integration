namespace EfiBankApiIntegration.Requests
{
    public class ChargeRequest
    {
        [JsonProperty("items")]
        public List<ChargeItem> Items { get; set; }// = new List<ChargeItem>();

        //[JsonProperty("shippings")]
        //public List<Shipping> Shippings { get; set; } = new List<Shipping>();

        [JsonProperty("payment")]
        public ChargePayment Payment { get; set; }
    }
}