# efipay-api-integration
Api para integração com o Efí Bank

Permite integração com a plataforma Efí Bank para geração de boletos e consulta de cobranças.

- [Site oficial do Efí Bank](https://sejaefi.com.br/)
- [Documentação complementa do Efí Pay](https://dev.efipay.com.br/docs/api-pix/credenciais/)

## Pré-requisitos
Será necessário obter os valores para as seguintes variáveis para execução dos exemplos abaixo:
- Menu > API > Aplicações > [Nome da aplicação criada]
string _clientId = "";
string _clientSecret = "";

### Obtendo um token de acesso:
```
var auth = new EfiBankAuthorization(_efiBankbaseUrl);
var authResponse = auth.Authorize("Client_Id_**", "Client_Secret_**");

_accessToken = authResponse!.AccessToken;
```

### Gerar boleto de cobrança para Pessoa Física:
```
var charge = new EfiBankBankingBillet(_efiBankbaseUrl);

var chargeItem = new ChargeItem
{
    Name = "Produto Teste",
    Value = 1090,
    Amount = 2
};
var chargePayment = new PFChargePayment
{
    BankingBillet = new PFBankingBilletRequest
    {
        ExpireAt = DateTime.UtcNow.AddDays(3),
        Customer = new PFChargeCustomer
        {
            Name = "Nome Cliente",
            Email = TEST_EMAIL,
            CPF = "14014603059",
            Birth = new DateTime(1977, 01, 15),
            PhoneNumber = "62986070247"
        }
    }
};
var chargeRequest = new PFChargeRequest
{
    Items = new List<ChargeItem> { chargeItem },
    Payment = chargePayment
};
var chargeResponse = charge.GenerateCharge(_accessToken, chargeRequest);

if (chargeResponse is ChargeResponseSuccess) {
    // Successo!!
} else if (chargeResponse is ChargeResponseError) {
    // Erro!!
}
```

### Gerar boleto de cobrança para Pessoa Jurídica:
```
var charge = new EfiBankBankingBillet(_efiBankbaseUrl);

var chargeItem = new ChargeItem
{
    Name = "Produto Teste",
    Value = 1090,
    Amount = 2
};
var chargePayment = new PJChargePayment
{
    BankingBillet = new PJBankingBilletRequest
    {
        ExpireAt = DateTime.UtcNow.AddDays(3),
        Customer = new PJChargeCustomer
        {
            Email = TEST_EMAIL,
            PhoneNumber = "62986070247",
            JuridicalPerson = new JuridicalPersonRequest
            {
                CorporateName = "Nome da Empresa",
                CNPJ = "99794567000144"
            }
        }
    }
};
var chargeRequest = new PJChargeRequest
{
    Items = new List<ChargeItem> { chargeItem },
    Payment = chargePayment
};
var chargeResponse = charge.GenerateCharge(_accessToken, chargeRequest);
```

### Obtendo detalhes do boleto gerado
```
var charge = new EfiBankBankingBillet(_efiBankbaseUrl);
var chargeId = "43878314";

var chargeResponse = charge.GetChargeById(_accessToken, chargeId);
```

### Alterar data de vencimento do boleto gerado
```
var charge = new EfiBankBankingBillet(_efiBankbaseUrl);
var chargeId = "43879035";

var chargeResponse = charge.ChangeChargeExpireAt(_accessToken, chargeId, DateTime.UtcNow.AddDays(5));

if (chargeResponse is ChargeResponseSuccess) {
    // Successo!!
} else if (chargeResponse is ChargeResponseError) {
    // Erro!!
}
```

### Reenviar boleto gerado por e-mail
```
var charge = new EfiBankBankingBillet(_efiBankbaseUrl);
var chargeId = "43879035";

var chargeResponse = charge.ResendChargeToEmail(_accessToken, chargeId, "mar***@gmail.com");
```

### Marcar boleto como pago
```
var charge = new EfiBankBankingBillet(_efiBankbaseUrl);
var chargeId = "43879033";

var chargeResponse = charge.SettleChargeById(_accessToken, chargeId);
```

### adicionar histórico ao boleto gerado
```
var charge = new EfiBankBankingBillet(_efiBankbaseUrl);
var chargeId = "43879035";

var chargeResponse = charge.AddHistoryToCharge(_accessToken, chargeId, "Adicionado pelo teste unitário.");
```

### Cancelar boleto gerado
```
var charge = new EfiBankBankingBillet(_efiBankbaseUrl);
var chargeId = "43878849";

var chargeResponse = charge.CancelChargeById(_accessToken, chargeId);
```
