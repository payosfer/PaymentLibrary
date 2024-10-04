using PaymentService.Dto.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Dto.Request
{
    public class RefundRequest
    {
        public long PaymentId { get; set; }

        [Required(ErrorMessage = "RRN bilgisini doldurunuz.")]
        public string RRN { get; set; }

        [Required(ErrorMessage = "İade Tutar bilgisini doldurunuz.")]
        public decimal RefundAmount { get; set; }

        public string RefundDescription { get; set; }

        public string EmailAddress { get; set; }

        public RefundDestinationType RefundDestinationType { get; set; } = RefundDestinationType.CARD;

        public bool ChargeFromMe { get; set; } = false;


        public long TerminalId { get; set; }
    }
}
