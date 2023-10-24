namespace EfiBankApiIntegration
{
    public abstract class EfiBankBankingIntegration
    {
        protected string _baseUrl { get; set; }

        public EfiBankBankingIntegration(string baseUrl)
        {
            _baseUrl = baseUrl;
        }
    }
}
