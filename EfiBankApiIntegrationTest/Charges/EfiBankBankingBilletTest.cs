using EfiBankApiIntegration.Charges;
using EfiBankApiIntegration.Requests;
using EfiBankApiIntegration.Responses;

namespace EfiBankApiIntegrationTest.Charges
{
    public class EfiBankBankingBilletTest : EfiBankTest
    {
        [Fact]
        public void GenerateChargeWithSuccessTest()
        {
            Assert.NotNull(_accessToken);

            var charge = new EfiBankBankingBillet(_efiBankbaseUrl);

            var chargeItem = new ChargeItem
            {
                Name = "Produto Teste",
                Value = 1090,
                Amount = 2
            };
            var chargePayment = new ChargePayment
            {
                BankingBillet = new BankingBilletRequest
                {
                    ExpireAt = DateTime.UtcNow.AddDays(3),
                    Customer = new ChargeCustomer
                    {
                        Name = "Nome Cliente",
                        Email = "mar***@gmail.com",
                        Cpf = "14014603059",
                        Birth = new DateTime(1977, 01, 15),
                        PhoneNumber = "62986070247"
                    }
                }
            };
            var chargeRequest = new ChargeRequest
            {
                Items = new List<ChargeItem> { chargeItem },
                Payment = chargePayment
            };
            var chargeResponse = charge.GenerateCharge(_accessToken, chargeRequest);

            Assert.NotNull(chargeResponse);
            Assert.True(chargeResponse is ChargeResponseSuccess);
            Assert.Equal(200, ((ChargeResponseSuccess)chargeResponse).Code);
            Assert.NotNull(((ChargeResponseSuccess)chargeResponse).Data.Pdf.Charge);
        }

        [Fact]
        public void GenerateChargeWithErrorTest()
        {
            Assert.NotNull(_accessToken);

            var charge = new EfiBankBankingBillet(_efiBankbaseUrl);

            var chargeItem = new ChargeItem
            {
                Name = "Produto Teste",
                Value = 1090,
                Amount = 2
            };
            var chargePayment = new ChargePayment
            {
                BankingBillet = new BankingBilletRequest
                {
                    ExpireAt = DateTime.UtcNow.AddDays(3),
                    Customer = new ChargeCustomer
                    {
                        Name = "Nome Cliente",
                        Email = "mar***@gmail.com",
                        Cpf = "14014603059",
                        Birth = new DateTime(1977, 01, 15),
                        PhoneNumber = "62986070247"
                    }
                }
            };
            var chargeRequest = new ChargeRequest
            {
                Items = new List<ChargeItem> { chargeItem },
                Payment = chargePayment
            };
            var chargeResponse = charge.GenerateCharge(_accessToken, chargeRequest);

            Assert.NotNull(chargeResponse);
            Assert.True(chargeResponse is ChargeResponseError);
            Assert.NotNull(((ChargeResponseError)chargeResponse).ErrorDescription);
        }

        [Fact]
        public void GetChargeByIdTest()
        {
            Assert.NotNull(_accessToken);

            var charge = new EfiBankBankingBillet(_efiBankbaseUrl);
            var chargeId = "43878314";

            var chargeResponse = charge.GetChargeById(_accessToken, chargeId);

            Assert.NotNull(chargeResponse);
            Assert.Equal(200, chargeResponse.Code);
            Assert.Equal(chargeId, chargeResponse.Data.ChargeId);
        }

        [Fact]
        public void ChangeChargeExpireAtTest()
        {
            Assert.NotNull(_accessToken);

            var charge = new EfiBankBankingBillet(_efiBankbaseUrl);
            var chargeId = "43879035";

            var chargeResponse = charge.ChangeChargeExpireAt(_accessToken, chargeId, DateTime.UtcNow.AddDays(5));

            Assert.True(chargeResponse);
        }

        [Fact]
        public void ResendChargeToEmailTest()
        {
            Assert.NotNull(_accessToken);

            var charge = new EfiBankBankingBillet(_efiBankbaseUrl);
            var chargeId = "43879035";

            var chargeResponse = charge.ResendChargeToEmail(_accessToken, chargeId, "mar***@gmail.com");

            Assert.True(chargeResponse);
        }

        [Fact]
        public void SettleChargeByIdTest()
        {
            Assert.NotNull(_accessToken);

            var charge = new EfiBankBankingBillet(_efiBankbaseUrl);
            var chargeId = "43879035";

            var chargeResponse = charge.SettleChargeById(_accessToken, chargeId);

            Assert.True(chargeResponse);
        }

        [Fact]
        public void CancelChargeByIdTest()
        {
            Assert.NotNull(_accessToken);

            var charge = new EfiBankBankingBillet(_efiBankbaseUrl);
            var chargeId = "43879874";

            var chargeResponse = charge.CancelChargeById(_accessToken, chargeId);

            Assert.True(chargeResponse);
        }

        [Fact]
        public void AddHistoryToChargeTest()
        {
            Assert.NotNull(_accessToken);

            var charge = new EfiBankBankingBillet(_efiBankbaseUrl);
            var chargeId = "43879035";

            var chargeResponse = charge.AddHistoryToCharge(_accessToken, chargeId, "Adicionado pelo teste unitário.");

            Assert.True(chargeResponse);
        }
    }
}
