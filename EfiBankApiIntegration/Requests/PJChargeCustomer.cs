namespace EfiBankApiIntegration.Requests
{
    public sealed class PJChargeCustomer
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone_number")]
        public string? PhoneNumber { get; set; }

        [JsonProperty("juridical_person")]
        public JuridicalPersonRequest JuridicalPerson { get; set; }
    }
}
