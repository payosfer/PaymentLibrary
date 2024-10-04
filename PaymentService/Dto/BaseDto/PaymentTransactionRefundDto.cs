using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Dto.BaseDto
{
    public class PaymentTransactionRefundDto : BasePaymentTransactionRefundDto
    {
        public string Currency { get; set; }
        public long? PaymentId { get; set; }
    }
}
