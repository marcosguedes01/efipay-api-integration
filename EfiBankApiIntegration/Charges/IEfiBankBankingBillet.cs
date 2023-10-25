using EfiBankApiIntegration.Requests;
using EfiBankApiIntegration.Responses;

namespace EfiBankApiIntegration.Charges
{
    public interface IEfiBankBankingBillet
    {
        IChargeResponse? GenerateCharge(string accessToken, ChargeRequest body);
        ChargeByIdResponse? GetChargeById(string accessToken, string chargeId);
        bool ChangeChargeExpireAt(string accessToken, string chargeId, DateTime newExpireAt);
        bool ResendChargeToEmail(string accessToken, string chargeId, string emailToSend);
        bool SettleChargeById(string accessToken, string chargeId);
        bool CancelChargeById(string accessToken, string chargeId);
        bool AddHistoryToCharge(string accessToken, string chargeId, string historyDescription);
    }
}
