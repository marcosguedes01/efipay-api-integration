namespace EfiBankApiIntegration.Requests
{
    public class ChargePayment
    {
        [JsonProperty("banking_billet")]
        public BankingBillet BankingBillet { get; set; }
    }
}
