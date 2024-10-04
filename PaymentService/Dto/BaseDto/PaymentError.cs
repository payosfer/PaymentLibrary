using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Dto.BaseDto
{
    public class PaymentError
    {
        public string ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public string ErrorGroup { get; set; }
    }
}
