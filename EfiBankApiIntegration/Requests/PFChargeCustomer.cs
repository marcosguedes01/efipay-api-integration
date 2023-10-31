namespace EfiBankApiIntegration.Requests
{
    public sealed class PFChargeCustomer
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("cpf")]
        public string CPF { get; set; }

        [JsonIgnore]
        public DateTime Birth { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("birth")]
        public string BirthStr
        {
            get
            {
                return Birth.ToString("yyyy-MM-dd");
            }
        }
    }
}
