using PaymentService.Dto.Request;
using PaymentService.Dto.Response;
using PaymentService.Generic;
using PaymentService.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Operations.PreAuth
{
    public class PreAuthOperation : ApiOperation<CreatePaymentResponse>
    {
        public PreAuthOperation(ResourceOptions options) : base(options) { }

        public CreatePaymentResponse PreAuth(CreatePaymentRequest request)
        {
            return Create("/payment/pre-auth-payment", request);
        }
    }
    
    
}
