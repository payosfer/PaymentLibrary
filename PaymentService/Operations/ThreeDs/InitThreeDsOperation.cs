using PaymentService.Dto.Request;
using PaymentService.Dto.Response;
using PaymentService.Generic;
using PaymentService.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Operations.ThereeDs
{
    public class InitThreeDsOperation:ApiOperation<InitThreeDsResponse>
    {
        public InitThreeDsOperation(ResourceOptions options) : base(options) { }

        public InitThreeDsResponse InitThreeDs(InitThreeDsRequest request)
        {
            return Create("/init3DSPayment?optional=false",request);
        }
    }
}
  