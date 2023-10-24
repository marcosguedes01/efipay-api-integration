using EfiBankApiIntegration.Security;

namespace EfiBankApiIntegrationTest
{
    public class EfiBankTest
    {
        protected string _efiBankbaseUrl = "https://cobrancas-h.api.efipay.com.br";
        protected string _accessToken;

        public EfiBankTest()
        {
            var auth = new EfiBankAuthorization(_efiBankbaseUrl);
            var authResponse = auth.Authorize("Client_Id_**", "Client_Secret_**");

            _accessToken = authResponse!.AccessToken;
        }
    }
}
