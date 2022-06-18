using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICENTA5.Models.ViewModels
{
    public class MyBusinessViewModel
    {
        public IEnumerable<Reservation> Reservations { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
