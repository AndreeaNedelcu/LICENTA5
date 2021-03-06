 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using LICENTA5.Models;
using Microsoft.AspNetCore.Identity;

namespace LICENTA5.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "varchar(50)")]
        
        public string firstName { get; set; }

        [PersonalData]
        [Column(TypeName = "varchar(50)")]
        public string lastName { get; set; }

        public List<Reservation> Reservations { get; set; }
      
    }
}
