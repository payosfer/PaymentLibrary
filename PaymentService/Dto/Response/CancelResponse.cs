using PaymentService.Dto.BaseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Dto.Response
{
    public class CancelResponse: BasePaymentRefundDto
    {
        public string RefundTypeText { get; set; }
        public int Currency { get; set; }
        public string CurrencyText { get; set; }
        public IList<PaymentTransactionRefundDto> PaymentTransactionRefunds { get; set; }
    }
}
