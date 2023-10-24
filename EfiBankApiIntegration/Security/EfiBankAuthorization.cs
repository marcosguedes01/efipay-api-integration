using EfiBankApiIntegration.Extensions;
using EfiBankApiIntegration.Responses;

namespace EfiBankApiIntegration.Security
{
    public class EfiBankAuthorization : EfiBankBankingIntegration, IEfiBankAuthorization
    {
        public EfiBankAuthorization(string baseUrl) : base(baseUrl)
        {
        }

        public AuthorizeResponse? Authorize(string clientId, string clientSecret)
        {
            var credencials = new Dictionary<string, string>{
                    {"client_id", clientId},
                    {"client_secret", clientSecret}
                };

            var client = new RestClient(_baseUrl);
            var request = new RestRequest("/v1/authorize");
            var authorization = (credencials["client_id"] + ":" + credencials["client_secret"]).ToBase64Encode();

            request.AddHeader("Authorization", "Basic " + authorization);
            request.AddHeader("Content-Type", "application/json");
            request.AddBody(new
            {
                grant_type = "client_credentials"
            });

            var response = client.ExecutePost(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<AuthorizeResponse>(response.Content!);
            }

            return null;
        }
    }
}