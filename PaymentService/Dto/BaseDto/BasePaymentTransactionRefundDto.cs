using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Dto.BaseDto
{
    public class BasePaymentTransactionRefundDto
    {
        public long Id { get; set; }
        public DateTime TranDate { get; set; }
        public string Status { get; set; }
        //public string RefundDestinationType { get; set; }
        public decimal RefundAmount { get; set; }
        public decimal RefundBankAmount { get; set; }
        public decimal RefundWalletAmount { get; set; }
        public string RRN { get; set; }
        public string AuthCode { get; set; }
        public string HostReference { get; set; }
        public string TransId { get; set; }
        public bool IsAfterSettlement { get; set; }
        public long PaymentTransactionId { get; set; }
    }
}
