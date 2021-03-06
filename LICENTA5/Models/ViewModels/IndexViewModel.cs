using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICENTA5.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<Restaurant> RestaurantsList { get; set; }
        public string SearchTerm { get; set; }
        public Restaurant RandomRestaurant { get; set; }
        public Restaurant NearestRestaurant { get; set; }
        public Restaurant MostPopularRestaurant { get; set; }
    }
}
