using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICENTA5.Models
{
    public class PremiumOffer
    {
        public int Id { get; set; }
        public DateTime Today { get; set; }
        public string Offer { get; set; }
        public string Code { get; set; }
    }
}
