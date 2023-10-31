namespace EfiBankApiIntegration.Requests
{
    public sealed class PJBankingBilletRequest : BankingBilletRequest
    {
        [JsonProperty("customer")]
        public PJChargeCustomer Customer { get; set; }
    }
}
