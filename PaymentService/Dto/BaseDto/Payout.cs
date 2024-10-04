using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Dto.BaseDto
{
    public class Payout
    {
        public decimal PaidAmount { get; set; }
        public decimal Parity { get; set; }
        public string Currency { get; set; }
        public decimal MerchantPayoutAmount { get; set; }
        public decimal SubMerchantMemberPayoutAmount { get; set; }
    }
}
