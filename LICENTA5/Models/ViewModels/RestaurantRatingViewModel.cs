using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICENTA5.Models.ViewModels
{
    public class RestaurantRatingViewModel
    {
        string SelectedRate { get; set; }
        public List<RestaurantRating> ListRatings { get; set; }
    }
}
