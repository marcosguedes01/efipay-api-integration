namespace EfiBankApiIntegration.Requests
{
    public sealed class PFChargeRequest : ChargeRequest
    {
        [JsonProperty("payment")]
        public PFChargePayment Payment { get; set; }
    }
}
