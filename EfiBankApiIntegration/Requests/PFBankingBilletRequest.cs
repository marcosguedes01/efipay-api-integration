namespace EfiBankApiIntegration.Requests
{
    public sealed class PFBankingBilletRequest : BankingBilletRequest
    {
        [JsonProperty("customer")]
        public PFChargeCustomer Customer { get; set; }
    }
}
