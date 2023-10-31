namespace EfiBankApiIntegration.Requests
{
    public sealed class PFChargePayment
    {
        [JsonProperty("banking_billet")]
        public PFBankingBilletRequest BankingBillet { get; set; }
    }
}
