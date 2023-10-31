namespace EfiBankApiIntegration.Requests
{
    public sealed class JuridicalPersonRequest
    {
        [JsonProperty("corporate_name")]
        public string CorporateName { get; set; }

        [JsonProperty("cnpj")]
        public string CNPJ { get; set; }
    }
}
