namespace EfiBankApiIntegration.Requests
{
    public abstract class BankingBilletRequest
    {
        [JsonIgnore]
        public DateTime ExpireAt { get; set; }

        [JsonProperty("expire_at")]
        public string ExpireAtStr
        {
            get
            {
                return ExpireAt.ToString("yyyy-MM-dd");
            }
        }

        [JsonProperty("configurations")]
        public BilletConfiguration Configuration { get; set; }

        
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
