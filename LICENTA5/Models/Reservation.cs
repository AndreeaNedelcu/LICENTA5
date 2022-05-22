using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using LICENTA5.Areas.Identity.Data;

namespace LICENTA5.Models
{
    public class Reservation
    {
        
        public int ReservationId { get; set; }
        [Required]
        [Range(1, 12, ErrorMessage = "Number of persons must be between 1 & 12")]
        public int NrPers { get; set; }
        [Required]
       
        public int HourComing { get; set; } //2h
        [Required]
        //[Range(typeof(DateTime), "1/2/2004", "3/4/2004",
        //ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [DateValidation]
        public DateTime Date { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
       
       [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }

        [ForeignKey("Restaurant")]
        public long RestaurantId { get; set; }
        [PremiumOffersValidation]
        public string? VoucherCode { get; set; }

        public bool Passed { get; set; }
    }
}
