using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LICENTA5.Areas.Identity.Data;

namespace LICENTA5.Models.ViewModels
{
    public class AddBookingViewModel
    {
        public Restaurant Restaurant { get; set; }
        [Required]
        [Range(1, 12, ErrorMessage = "Number of persons must be between 1 & 12")] 

        
        public int NrPers { get; set; }
        [Required]

        public int HourComing { get; set; } //2h
        [Required]
       [DateValidation]
        public DateTime Date { get; set; }
        public string PageTitle { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
