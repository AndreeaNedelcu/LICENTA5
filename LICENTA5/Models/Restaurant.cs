using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LICENTA5.Models
{
    public class Restaurant
    {
        public long RestaurantID { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        
        public string RestaurantName { get; set; }

        [Required]
        [Phone]
        public string PhoneNo { get; set; }
        [Required]
        [MinLength(20, ErrorMessage = "Description should have more than 20 characters")]
        public string Description { get; set; }
        [Required]

        public string Type { get; set; }
        [Required]
        [Range(10, 100, ErrorMessage ="Number of persons must be between 10 & 100")]
        public int nrPersMax { get; set; }

        public int EmptySeats { get; set; }
        [Required]
        [Range(1,24)]
        public int openHour { get; set; }
        [Required]
        [Range(1, 24)]
        public int closingHour { get; set; }

        public string PhotoPath { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public ICollection<RestaurantGallery> RestaurantGallery { get; set; }

        List<Reservation> ListOfReservations { get; set; }
        List<RestaurantRating> Ratings { get; set; }

        public bool Confirmed { get; set; }
        public string AddedBy { get; set; }



    }
}
