using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Dto.Request
{
    public class InitThreeDsRequest:CreatePaymentRequest
    {
        public string SuccessUrl { get; set; }

        public string ErrorUrl { get; set; }
    }
}
