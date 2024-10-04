using PaymentService.Dto.Request;
using PaymentService.Dto.Response;
using PaymentService.Generic;
using PaymentService.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Operations.Refund
{
    public class RefundOperation : ApiOperation<CancelResponse>
    {
        public RefundOperation(ResourceOptions options) : base(options) { }

        public CancelResponse Refund(RefundRequest request)
        {
            return Create("/payment/refund-payment", request);
        }

    }
}
