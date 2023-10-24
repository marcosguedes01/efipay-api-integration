namespace EfiBankApiIntegration.Responses
{
    public class ChargeByIdData
    {
        [JsonProperty("charge_id")]
        public string ChargeId { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paid_value")]
        public int PaidValue { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("custom_id")]
        public object CustomId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("notification_url")]
        public object NotificationUrl { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        [JsonProperty("history")]
        public List<History> History { get; set; }

        [JsonProperty("shippings")]
        public List<Shipping> Shippings { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("payment")]
        public Payment Payment { get; set; }
    }
}
