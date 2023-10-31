namespace EfiBankApiIntegration.Requests
{
    public sealed class PJChargePayment
    {
        [JsonProperty("banking_billet")]
        public PJBankingBilletRequest BankingBillet { get; set; }
    }
}
