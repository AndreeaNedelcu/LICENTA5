using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LICENTA5.Models
{
    public class RestaurantRating
    {
        public int Id{ get; set; }
       
        public string userId { get; set; }
        public int Rating { get; set; }

        [ForeignKey("Restaurant")]
        public long RestaurantId { get; set; }
    }
}
