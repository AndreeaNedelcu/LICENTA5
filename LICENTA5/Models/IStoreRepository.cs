using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICENTA5.Models
{
   public interface IStoreRepository
    {
        IQueryable<Restaurant> Restaurants { get; }
        Restaurant Add(Restaurant restaurant);
        Restaurant Update(Restaurant restChanges);
        Restaurant Delete(long id);
        Restaurant GetRestaurant(int Id);

        List<RestaurantGallery> GetGallery(int id);

        Reservation AddReservation(Reservation reservation);


        IEnumerable<Reservation> GeAlltReservations();
        IEnumerable<Reservation> GetReservations(string userId);
        IEnumerable<Reservation> GetReservationsAtRestaurant(long restaurantId);
        Reservation GetReservation(string userId, int resId);
        Reservation Update(Reservation reservationChanged, string userId);

        Reservation DeleteReservation(int id);
        IEnumerable<Restaurant> Search(string SearchTerm);

        IEnumerable<RestaurantRating> Ratings(long restId);

        RestaurantRating AddRating(RestaurantRating review);
        GiftCard AddGiftCard(GiftCard card);

        PremiumOffer AddPremiumOffer(PremiumOffer offer);

        PremiumOffer DeletePremiumOffer(int id);

        PremiumOffer UpdatePremiumOffer(PremiumOffer offerChanges);
        IEnumerable<PremiumOffer> GetOffers();
    }
}
