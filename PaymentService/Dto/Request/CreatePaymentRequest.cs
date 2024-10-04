using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentService.Dto.Enums;

namespace PaymentService.Dto.Request
{
    public class CreatePaymentRequest
    {
        [Range(0, long.MaxValue)]
        public long? TerminalId { get; set; }

        [Range(0, long.MaxValue)]
        public long? BankTerminalId { get; set; }

        [Required(ErrorMessage = "MerchantId bilgisini doldurunuz.")]
        [Range(0, long.MaxValue)]
        public long MerchantId { get; set; }

        [Required(ErrorMessage = "Tutar bilgisini doldurunuz.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Tutar sıfırdan küçük olamaz.")]
        public decimal Amount { get; set; }

        public decimal? PaidAmount { get; set; } = decimal.Zero;

        public decimal? WalletAmount { get; set; } = decimal.Zero;


        [Range(1, long.MaxValue)]
        public int Installment { get; set; } = 1;

        public Currency? Currency { get; set; }

        [StringLength(50, MinimumLength = 10)]

        [Required]
        public string PaymentDescription { get; set; }

        public string RRN { get; set; }


        [Required(ErrorMessage = "Action bilgisini doldurunuz.")]
        public PaymentAction Action { get; set; }

        [Required]
        public PaymentType PaymentType { get; set; }

        public string BankOrderId { get; set; }


        [Required(ErrorMessage = "Kart model bilgisini doldurunuz.")]
        public PaymentCardDto Card { get; set; }
    }
}
