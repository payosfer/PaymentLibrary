using System.ComponentModel.DataAnnotations;

namespace PaymentService.Dto
{
    public class PaymentCardDto
    {

        public string CardHolderName { get; set; }

        [Required]
        public string CardNumber { get; set; }

        [Required]
        public string ExpireYear { get; set; }

        [Required]
        public string ExpireMonth { get; set; }

        [Required]
        public string Cvc { get; set; }
    }
}