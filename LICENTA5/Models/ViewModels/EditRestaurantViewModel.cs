using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICENTA5.Models.ViewModels
{
    public class EditRestaurantViewModel :RestaurantCreateViewModel
    {
        public int Id { get; set; }
        public string ExistingPhotoPath { get; set; }

        public ICollection<RestaurantGallery> ExistingRestaurantGallery { get; set; }
    }
}
