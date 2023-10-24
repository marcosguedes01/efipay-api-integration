using EfiBankApiIntegration.Requests;
using EfiBankApiIntegration.Responses;

namespace EfiBankApiIntegration.Charges
{
    public class EfiBankBankingBillet : EfiBankBankingIntegration, IEfiBankBankingBillet
    {
        public EfiBankBankingBillet(string baseUrl) : base(baseUrl)
        {
        }

        public ChargeResponse? GenerateCharge(string accessToken, ChargeRequest body)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest("v1/charge/one-step");

            request.AddHeader("Authorization", "Bearer " + accessToken);
            request.AddHeader("Content-Type", "application/json");
            request.AddBody(JsonConvert.SerializeObject(body));

            var response = client.ExecutePost(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<ChargeResponse>(response.Content!);
            }

            return null;
        }

        public ChargeByIdResponse? GetChargeById(string accessToken, string chargeId)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest($"v1/charge/{chargeId}");

            request.AddHeader("Authorization", "Bearer " + accessToken);
            request.AddHeader("Content-Type", "application/json");

            var response = client.ExecuteGet(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<ChargeByIdResponse>(response.Content!);
            }

            return null;
        }

        public bool ChangeChargeExpireAt(string accessToken, string chargeId, DateTime newExpireAt)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest($"v1/charge/{chargeId}/billet");

            request.AddHeader("Authorization", "Bearer " + accessToken);
            request.AddHeader("Content-Type", "application/json");
            request.AddBody(new
            {
                expire_at = newExpireAt.ToString("yyyy-MM-dd")
            });

            var response = client.ExecutePut(request);

            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }

        public bool ResendChargeToEmail(string accessToken, string chargeId, string emailToSend)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest($"v1/charge/{chargeId}/billet/resend");

            request.AddHeader("Authorization", "Bearer " + accessToken);
            request.AddHeader("Content-Type", "application/json");
            request.AddBody(new
            {
                email = emailToSend
            });

            var response = client.ExecutePost(request);

            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }

        public bool SettleChargeById(string accessToken, string chargeId)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest($"v1/charge/{chargeId}/settle");

            request.AddHeader("Authorization", "Bearer " + accessToken);
            request.AddHeader("Content-Type", "application/json");

            var response = client.ExecutePut(request);

            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }

        public bool CancelChargeById(string accessToken, string chargeId)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest($"v1/charge/{chargeId}/cancel");

            request.AddHeader("Authorization", "Bearer " + accessToken);
            request.AddHeader("Content-Type", "application/json");

            var response = client.ExecutePut(request);

            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }

        public bool AddHistoryToCharge(string accessToken, string chargeId, string historyDescription)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest($"v1/charge/{chargeId}/history");

            request.AddHeader("Authorization", "Bearer " + accessToken);
            request.AddHeader("Content-Type", "application/json");
            request.AddBody(new
            {
                description = historyDescription
            });

            var response = client.ExecutePost(request);

            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }
    }
}
