## Introduction
This library provides a streamlined way to integrate payment processing into your .NET applications. It simplifies the setup and execution of various payment transactions, ensuring efficient and secure communication with payment gateways.

## Dependency
This library was created with .NET 7.0. Please ensure that you are using .NET 7.0 or a compatible version.

## Install
To install the library in your project, use the following command:

```bash
dotnet add package PaymentServicePackage

## Features
- Easy integration with multiple payment gateways
- Supports various payment methods (credit cards, etc.)
- Provides pre-built methods for transaction handling (authorization, capture, refund, cancellation)
- Built with performance optimization for high-volume transactions

 ## Usage
Here's a simple example of how to use the library to process a payment:

```csharp
using PaymentService;
using PaymentService.Dto;
using PaymentService.Dto.Enums;
using PaymentService.Dto.Request;
using PaymentService.Dto.Response;
using PaymentService.Operations.Payment;
using PaymentService.Options;

// Create a payment request
 var options = new ResourceOptions
 {
     BaseUrl = "",
     ApiKey = "",
     SecretKey = "",
     AuthUrl = "",
     Username = "test",
     Password = "",
     Scobe = ""
 };

 var request = new CreatePaymentRequest
 {
     TerminalId = 1,
     BankTerminalId = 1,
     MerchantId = your-merchant-id,
     Amount = 100,
     Currency = Currency.TRY,
     PaymentDescription = "Ödeme Test İşlemi",
     RRN="1a23456",
     BankOrderId="1b23456",
     
     Card = new PaymentCardDto
     {
         CardHolderName = "Test",
         CardNumber = "1111111111111111",
         ExpireMonth = "01",
         ExpireYear = "2001",
         Cvc = "111"
     }
 };

// Process the payment
var paymentOperation = new PaymentOperation(options);
CreatePaymentResponse payment = paymentOperation.CreatePayment(request);

if (payment.PaymentStatus == 1)
{
    Console.WriteLine("Payment processed successfully!");
    Console.WriteLine($"Payment transaction number: {payment.TransId} ");
    Console.WriteLine($"Transaction Amount: {payment.Amount} ");
}
else
{
    Console.WriteLine($"Payment failed: {payment.PaymentError.ErrorCode}");
    Console.WriteLine($"Payment failed: {payment.PaymentError.ErrorDescription}");
}

## Contributing
Contributions are welcome! If you want to contribute to this project, please fork the repository, make your changes, and submit a pull request. For major changes, please open an issue first to discuss what you would like to change.


## License
This project is licensed under the MIT License. See the LICENSE file for more details.


## Contact
For any questions or issues, please feel free to reach out at [your-email@example.com].

