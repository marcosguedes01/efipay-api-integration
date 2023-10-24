using EfiBankApiIntegration.Responses;

namespace EfiBankApiIntegration.Security
{
    public interface IEfiBankAuthorization
    {
        AuthorizeResponse? Authorize(string clientId, string clientSecret);
    }
}
