using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICENTA5.Models
{
    public class RestaurantGallery
    {
        public int Id { get; set; }
     //   public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public Restaurant restaurants { get; set; }
    }
}
