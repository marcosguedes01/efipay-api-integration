namespace EfiBankApiIntegration.Responses
{
    public class ChargeResponseError : IChargeResponse
    {
        private string _errorDescription;

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("error_description")]
        public ErrorDescription ErrorDescription { get; set; }
    }

    public class ErrorDescription
    {
        [JsonProperty("property")]
        public string Property { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

