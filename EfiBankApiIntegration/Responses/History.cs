namespace EfiBankApiIntegration.Responses
{
    public class History
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }
}
