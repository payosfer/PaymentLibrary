using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Dto.Enums
{
    public enum PaymentStatus
    {
        [EnumMember(Value = "FAILURE")] FAILURE,

        [EnumMember(Value = "SUCCESS")] SUCCESS,

        [EnumMember(Value = "INIT_THREEDS")] INIT_THREEDS,

        [EnumMember(Value = "CALLBACK_THREEDS")]
        CALLBACK_THREEDS,

        [EnumMember(Value = "WAITING")] WAITING
    }
}
