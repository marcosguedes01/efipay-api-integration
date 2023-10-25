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

### Gerar boleto de cobrança:
```
var charge = new EfiBankBankingBillet(_efiBankbaseUrl);

var chargeItem = new ChargeItem
{
    Name = "Produto Teste",
    Value = 1090,
    Amount = 2
};
var chargePayment = new ChargePayment
{
    BankingBillet = new BankingBillet
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
if (chargeResponse is ChargeResponseSuccess) {
    // Successo!!
} else if (chargeResponse is ChargeResponseError) {
    // Erro!!
}
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
