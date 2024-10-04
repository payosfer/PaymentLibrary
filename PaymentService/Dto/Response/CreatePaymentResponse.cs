using PaymentService.Dto.BaseDto;
using PaymentService.Dto.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Dto.Response
{
    public class CreatePaymentResponse: BasePaymentDto
    {
        public string CardUserKey { get; set; }
        public string CardToken { get; set; }
        public long? FraudId { get; set; }
        public FraudAction? FraudAction { get; set; }
        public Dictionary<string, object> AdditionalData { get; set; }
        public IList<PaymentTransaction> PaymentTransactions;
    }
}
