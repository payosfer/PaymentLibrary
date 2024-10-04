using PaymentService.Dto.Request;
using PaymentService.Dto.Response;
using PaymentService.Generic;
using PaymentService.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Operations.PreAuthCancel
{
    public class PreAuthCancelOperation : ApiOperation<CancelResponse>
    {
        public PreAuthCancelOperation(ResourceOptions options) : base(options) { }

        public CancelResponse PreAuthCancel(CancelRequest request)
        {
            return Create("/payment/pre-auth-cancel", request);
        }

    }
}
