using PaymentService.Dto.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Dto.BaseDto
{
    public class Loyalty
    {
        public LoyaltyType Type { get; set; }
        public Reward Reward { get; set; }
        public string Message { get; set; }
    }
}
