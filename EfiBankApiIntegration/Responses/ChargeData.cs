namespace EfiBankApiIntegration.Responses
{
    public class ChargeData
    {
        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("billet_link")]
        public string BilletLink { get; set; }

        [JsonProperty("pdf")]
        public Pdf Pdf { get; set; }

        [JsonProperty("expire_at")]
        public string ExpireAt { get; set; }

        [JsonProperty("charge_id")]
        public string ChargeId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("payment")]
        public string Payment { get; set; }
    }
}
