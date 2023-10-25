namespace EfiBankApiIntegration.Requests
{
    public class ChargePayment
    {
        [JsonProperty("banking_billet")]
        public BankingBilletRequest BankingBillet { get; set; }
    }
}
