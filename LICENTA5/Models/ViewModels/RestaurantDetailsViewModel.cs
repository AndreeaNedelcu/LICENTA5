using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICENTA5.Models.ViewModels
{
    public class RestaurantDetailsViewModel
    {
        public Restaurant Restaurant { get; set; }
        public string PageTitle { get; set; }

        public List<GalleryModel> Gallery { get; set; }

        public string SelectedRate { get; set; }
        public List<RestaurantRating> RestaurantRatings { get; set; }
        
    }
}
