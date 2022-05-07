using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LICENTA5.Areas.Identity.Data;
using LICENTA5.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LICENTA5.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private IStoreRepository repository;
        public RestaurantController(UserManager<ApplicationUser> userManager, IStoreRepository repo)
        {
            _userManager = userManager;
            repository = repo;
        }

        [HttpGet]
        public async Task<string> GetCurrentUserId()
        {
            ApplicationUser usr = await GetCurrentUserAsync();
            return usr?.Id;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
        public IActionResult NewRestaurantInfo()
        {
            return View();
        }


        public IActionResult MyBusiness()
        {
            var userName = _userManager.GetUserName(User);
            var user = GetCurrentUserAsync();
            var restaurant = repository.Restaurants.Where(r => r.AddedBy.Equals(userName)).FirstOrDefault();
            IEnumerable<Reservation> reservations = null;
            try
            {
                reservations = repository.GetReservationsAtRestaurant(restaurant.RestaurantID);
            }
            catch(NullReferenceException ex ){
                reservations = null;
            }

            DateTime currentDate = DateTime.Now;
            int currentHour = currentDate.Hour;

            ViewData["CurrentHour"] = currentHour;
            ViewData["RestaurantName"] = restaurant.RestaurantName;
            ViewData["RestaurantOpen"] = restaurant.openHour;
            ViewData["RestaurantClose"] = restaurant.closingHour;
            ViewData["RestaurantDesc"] = restaurant.Description;
            ViewData["RestaurantCapacity"] = restaurant.nrPersMax;
            ViewData["RestaurantID"] = restaurant.RestaurantID;
            
            return View(reservations);
        }
    }
}
