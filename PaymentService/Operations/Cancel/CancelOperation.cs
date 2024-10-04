using PaymentService.Dto.Request;
using PaymentService.Dto.Response;
using PaymentService.Generic;
using PaymentService.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Operations.Cancel
{
    public class CancelOperation : ApiOperation<CancelResponse>
    {
        public CancelOperation(ResourceOptions options) : base(options) { }

        public CancelResponse Cancel(CancelRequest request)
        {
            return Create("/payment/cancel-payment", request);
        }
    }
}
