using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Dto.BaseDto
{
    public class Reward
    {
        public decimal CardRewardMoney { get; set; }
        public decimal FirmRewardMoney { get; set; }
        public decimal TotalRewardMoney { get; set; }
    }
}
