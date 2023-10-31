namespace EfiBankApiIntegration.Requests
{
    public sealed class PJChargeRequest : ChargeRequest
    {
        [JsonProperty("payment")]
        public PJChargePayment Payment { get; set; }
    }
}
