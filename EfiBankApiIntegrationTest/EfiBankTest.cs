using EfiBankApiIntegration.Security;
using Microsoft.Extensions.Configuration;

namespace EfiBankApiIntegrationTest
{
    public class EfiBankTest
    {
        protected string _efiBankbaseUrl = "https://cobrancas-h.api.efipay.com.br";
        protected string _accessToken;

        public EfiBankTest()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            var clientId = config.GetSection("clientId").Value;
            var clientSecret = config.GetSection("clientSecret").Value;

            var auth = new EfiBankAuthorization(_efiBankbaseUrl);
            var authResponse = auth.Authorize(clientId!, clientSecret!);

            _accessToken = authResponse!.AccessToken;
        }
    }
}
