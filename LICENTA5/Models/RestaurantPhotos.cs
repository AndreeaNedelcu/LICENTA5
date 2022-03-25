using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace LICENTA5.Models
{
    public class RestaurantPhotos
    {
        public int id { get; set; }
        public IFormFile Photo { get; set; }

        public int RestaurantId { get; set; }
    }
}
