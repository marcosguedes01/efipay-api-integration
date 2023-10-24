﻿namespace EfiBankApiIntegration.Responses
{
    public class BankingBillet
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
    }
}
