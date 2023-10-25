namespace EfiBankApiIntegration.Responses
{
    public class Payment
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("message")]
        public object Message { get; set; }

        [JsonProperty("banking_billet")]
        public BankingBilletResponse BankingBillet { get; set; }
    }
}
