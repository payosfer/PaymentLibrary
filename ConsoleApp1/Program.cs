using System;
using PaymentService;
using PaymentService.Dto;
using PaymentService.Dto.Enums;
using PaymentService.Dto.Request;
using PaymentService.Dto.Response;
using PaymentService.Operations.Payment;
using PaymentService.Operations.PostAuth;
using PaymentService.Options;
using PaymentService.Payment;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new ResourceOptions
            {
                BaseUrl = "https://localhost:7004/api/app",
                ApiKey = "CastleService_Swagger",
                SecretKey = "1q2w3e*",
                AuthUrl = "https://localhost:7600",
                Username = "test",
                Password = "1q2w3E*",
                Scobe = "offline_access"
            };

            var request = new CreatePaymentRequest
            {
                TerminalId = 1,
                BankTerminalId = 100000013506,
                MerchantId = 559087178,
                Amount = 150,
                Currency = Currency.TRY,
                PaymentDescription = "Ödeme test İşlemi",
                Card = new PaymentCardDto
                {
                    CardHolderName = "Esra Test",
                    CardNumber = "5421190122090656",
                    ExpireMonth = "04",
                    ExpireYear = "2028",
                    Cvc = "916"
                }
            };

            try
            {
                var paymentOperation = new PaymentOperation(options);
                CreatePaymentResponse payment = paymentOperation.CreatePayment(request);

                if (payment.PaymentStatus == 1)
                {
                    Console.WriteLine("Ödeme işlemi başarılı");
                    Console.WriteLine($"Ödeme işlem numarası {payment.TransId} ");
                    Console.WriteLine($"İşlem Tutarı {payment.Amount} ");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }
        }
    }
}