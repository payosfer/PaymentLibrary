using System.Runtime.Serialization;

namespace PaymentService.Dto.Enums
{
    public enum Currency
    {
        [EnumMember(Value = "TRY")] TRY,
        [EnumMember(Value = "USD")] USD,
        [EnumMember(Value = "EUR")] EUR,
        [EnumMember(Value = "GBP")] GBP,
        [EnumMember(Value = "ARS")] ARS,
        [EnumMember(Value = "BRL")] BRL,
        [EnumMember(Value = "CNY")] CNY,
        [EnumMember(Value = "AED")] AED,
        [EnumMember(Value = "IQD")] IQD
    }
}