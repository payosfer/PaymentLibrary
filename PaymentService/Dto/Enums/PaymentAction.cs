﻿using System.Runtime.Serialization;

namespace PaymentService.Dto
{
    public enum PaymentAction
    {
        [EnumMember(Value = "AUTH")] AUTH,
        [EnumMember(Value = "PRE_AUTH")] PRE_AUTH,
        [EnumMember(Value = "POST_AUTH")] POST_AUTH
    }
}