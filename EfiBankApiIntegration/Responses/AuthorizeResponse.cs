namespace EfiBankApiIntegration.Responses
{
    public sealed class AuthorizeResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("expire_at")]
        public string ExpireAt { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }
    }
}
