using PaymentService.Dto.Request;
using PaymentService.Dto.Response;
using PaymentService.Generic;
using PaymentService.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Operations.PostAuth
{
    public class PostAuthOperation : ApiOperation<CreatePaymentResponse>
    {
        public PostAuthOperation(ResourceOptions options) : base(options) { }

        public CreatePaymentResponse PostAuth(int paymentId, PostAuthRequest request)
        {
            return Create($"/payment/auth-payment/{paymentId}", request);
        }

    }
}
