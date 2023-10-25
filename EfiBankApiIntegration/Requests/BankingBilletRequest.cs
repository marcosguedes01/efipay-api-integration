namespace EfiBankApiIntegration.Requests
{
    public class BankingBilletRequest
    {
        [JsonIgnore]
        public DateTime ExpireAt { get; set; }

        [JsonProperty("customer")]
        public ChargeCustomer Customer { get; set; }

        [JsonProperty("expire_at")]
        public string ExpireAtStr
        {
            get
            {
                return ExpireAt.ToString("yyyy-MM-dd");
            }
        }
    }
}
