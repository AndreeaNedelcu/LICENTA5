using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICENTA5.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context;
        int resID = 0;
        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
           
        }
        public IQueryable<Restaurant> Restaurants => context.Restaurants;

        public Restaurant Add(Restaurant restaurant)
        {
            context.Restaurants.Add(restaurant);
            
            context.SaveChanges();
            
            return restaurant;
        }

        public Reservation AddReservation(Reservation reservation)
        {
            context.Reservations.Add(reservation);

            context.SaveChanges();

            return reservation;
        }

        public Restaurant Delete(long id)
        {
            Restaurant res = context.Restaurants.Find(id);
            if (res != null)
            {

                var resId = res.RestaurantID;
                RestaurantGallery[] resPhotos = context.RestaurantGallery.Where(e => e.restaurants.RestaurantID.Equals(resId)).ToArray();
                context.RestaurantGallery.RemoveRange(resPhotos);
                context.Restaurants.Remove(res);
                
                
                context.SaveChanges();

            }

            return res;
        }

        public Restaurant GetRestaurant(int Id)
        {
            long id = (long)Id;
           

            return context.Restaurants.Find(id);
        }

        public List<RestaurantGallery> GetGallery(int id)
        {
            //long ID = (long)id;
           
            List<RestaurantGallery> lista = new List<RestaurantGallery>();
            foreach (var f in context.RestaurantGallery)
            {
               // resID = (int)f.restaurants.RestaurantID;
                if (f.restaurants != null && f.restaurants.RestaurantID.Equals(id))
                {
                    //f.RestaurantId.Equals(id) ||

                    lista.Add(f);
                }
            }
            return lista;
        }



        public Restaurant Update(Restaurant restChanges)
        {
            var res = context.Restaurants.Attach(restChanges);
            res.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return restChanges;
        }

        public IEnumerable<Reservation> GetReservations(string userId)
        {
            // return context.Reservations.Where(e => e.ApplicationUser.Id.Equals(userId));
            return context.Reservations.Where(e => e.UserId.Equals(userId));
        }

        public Reservation GetReservation(string userId, int resId)
        {
            return context.Reservations.Where(e => e.UserId.Equals(userId)).Where(ev => ev.ReservationId.Equals(resId)).FirstOrDefault();
        }

        public Reservation Update(Reservation reservationChanged, string userId)
        {

            var reservations = context.Reservations.Attach(reservationChanged);
            reservations.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return reservationChanged;
        }

       
        public Reservation DeleteReservation(int id)
        {
            Reservation res = context.Reservations.Find(id);
          
            if (res != null)
            {
                context.Reservations.Remove(res);
                
                context.SaveChanges();

            }

            return res;
        }

       

        public IEnumerable<Restaurant> Search(string SearchTerm)
        {
            
            var result= context.Restaurants.AsEnumerable();
            if (string.IsNullOrEmpty(SearchTerm))
            {
                return result;
            }

            //return result.Where(e => e.RestaurantName.ToLower().Contains(SearchTerm) ||
            //                                e.Type.ToLower().Contains(SearchTerm)).ToList();

            return result.Where(e => e.RestaurantName.Contains(SearchTerm, StringComparison.InvariantCultureIgnoreCase) ||
                                           e.Type.ToLower().Contains(SearchTerm, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

        public IEnumerable<RestaurantRating> Ratings(long restId)
        {
            return context.Ratings.Where(e => e.RestaurantId.Equals(restId));
        }

        public RestaurantRating AddRating(RestaurantRating review)
        {
            context.Ratings.Add(review);

            context.SaveChanges();

            return review;
        }

        public IEnumerable<Reservation> GetReservationsAtRestaurant(long restaurantId)
        {
            return context.Reservations.Where(e => e.RestaurantId.Equals(restaurantId));
        }

        public GiftCard AddGiftCard(GiftCard card)
        {
            context.GiftCards.Add(card);

            context.SaveChanges();

            return card;
        }
    }
}
