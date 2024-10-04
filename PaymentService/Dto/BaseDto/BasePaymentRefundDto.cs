using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Dto.BaseDto
{
    public class BasePaymentRefundDto
    {
        public long Id { get; set; }
        public DateTime TranDate { get; set; }
        public int Status { get; set; }
        public string StatusText { get; set; }
        public int RefundDestinationType { get; set; }
        public string RefundDestinationTypeText { get; set; }
        public decimal RefundAmount { get; set; }
        public decimal RefundBankAmount { get; set; }
        public decimal RefundWalletAmount { get; set; }
        public string RRN { get; set; }
        public string AuthCode { get; set; }
        public string HostReference { get; set; }
        public string TransId { get; set; }
        public long PaymentId { get; set; }
        public string RefundStatus { get; set; }
        public int RefundType { get; set; }
        public int? RefundActionType { get; set; }
        public string RefundActionTypeText { get; set; }

    }
}
