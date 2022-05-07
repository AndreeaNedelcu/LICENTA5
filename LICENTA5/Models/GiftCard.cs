using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LICENTA5.Models
{
    public class GiftCard
    {
        [Key]
        public int GiftCardID { get; set; }

        [Required]
        public int CardValue { get; set; }

        [Required]
        [EmailAddress]
        public string ReceiverEmail { get; set; }

        [Required]
        public string SenderFullName { get; set; }

        [Required]
        [MinLength(13, ErrorMessage = "The card number should have at least 13 digits")]
        [MaxLength(16, ErrorMessage = "The card number should have maximum 16 digits")]
        public string SenderCardNo { get; set; }

        [Required]
        [DateValidation]
        public DateTime ExpirationDate { get; set; }

        [Required]
        [Range(100, 999, ErrorMessage = "CVV should have 3 digits")]
        public int SenderCVV { get; set; }

        public string? Message { get; set; }

    }
}
