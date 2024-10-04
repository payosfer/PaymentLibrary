using PaymentService.Dto.Request;
using PaymentService.Dto.Response;
using PaymentService.Generic;
using PaymentService.Options;

namespace PaymentService.Operations.Payment
{
    public class PaymentOperation : ApiOperation<CreatePaymentResponse>
    {
        public PaymentOperation(ResourceOptions options) : base(options) { }

        public CreatePaymentResponse CreatePayment(CreatePaymentRequest request)
        {
            return Create("/payment/payment", request);
        }

    }
}