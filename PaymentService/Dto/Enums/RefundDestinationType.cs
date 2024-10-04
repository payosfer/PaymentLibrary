using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Dto.Enums
{
    public enum RefundDestinationType
    {
        [EnumMember(Value = "CARD")]
        CARD,
        [EnumMember(Value = "WALLET")] WALLET
    }
}
