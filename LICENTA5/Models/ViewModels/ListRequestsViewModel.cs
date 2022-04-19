using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICENTA5.Models.ViewModels
{
    public class ListRequestsViewModel
    {
      
        public IQueryable<Restaurant> RestaurantsNotConfirmed { get; set; }
        public bool IsSelected { get; set; }
    }
}
