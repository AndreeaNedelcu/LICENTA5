using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LICENTA5.Areas.Identity.Data;
using LICENTA5.Models;
using LICENTA5.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LICENTA5.Controllers
{
    
    public class RestaurantController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private IStoreRepository repository;
        public int PageSizeReservations = 6;
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

        [HttpGet]
        [Authorize(Roles="Business")]
        public IActionResult MyBusiness(string? sortOrder, string? filterParameter, int page = 1)
        {

            var userName = _userManager.GetUserName(User);
            var user = GetCurrentUserAsync();
            var restaurant = repository.Restaurants.Where(r => r.AddedBy.Equals(userName)).FirstOrDefault();
            IEnumerable<Reservation> reservations = null;
            try
            {
                reservations = repository.GetReservationsAtRestaurant(restaurant.RestaurantID);
            }
            catch (NullReferenceException ex) {
                reservations = null;
            }


            switch (sortOrder)
            {
                case "Recent":
                    reservations = reservations.OrderByDescending(s => s.Date);
                    break;
                case "Oldest":
                    reservations = reservations.OrderBy(s => s.Date);
                    break;

                default:
                    reservations = reservations.OrderBy(s => s.ReservationId);
                    break;
            }

            if (!String.IsNullOrEmpty(filterParameter))
            {
                reservations = reservations.Where(f => f.Date.ToShortDateString().Equals(DateTime.Now.ToShortDateString()));
            }

            DateTime currentDate = DateTime.Now;
            int currentHour = currentDate.Hour;

            int[] array = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            
            
               
                foreach(var res in reservations)
                {
                    if (res.Date.Month.Equals(1))
                    {
                        array[0]++;
                    }
                    else if (res.Date.Month.Equals(2))
                    {
                        array[1]++;
                    }
                    else if (res.Date.Month.Equals(3))
                    {
                        array[2]++;
                    }
                    else if (res.Date.Month.Equals(4))
                    {
                        array[3]++;
                    }
                    else if (res.Date.Month.Equals(5))
                    {
                        array[4]++;
                    }
                    else if (res.Date.Month.Equals(6))
                    {
                        array[5]++;
                    }
                    else if (res.Date.Month.Equals(7))
                    {
                        array[6]++;
                    }
                    else if (res.Date.Month.Equals(8))
                    {
                        array[7]++;
                    }
                    else if (res.Date.Month.Equals(9))
                    {
                        array[8]++;
                    }
                    else if (res.Date.Month.Equals(10))
                    {
                        array[9]++;
                    }
                    else if (res.Date.Month.Equals(11))
                    {
                        array[10]++;
                    }
                    else if (res.Date.Month.Equals(12))
                    {
                        array[11]++;
                    }
                
                 }

            // for today's chart
            var reservationForWeekChart = reservations.Where(f => f.Date.ToShortDateString().Equals(DateTime.Now.ToShortDateString())).GroupBy(e => e.HourComing);
         
            Dictionary<int, int> hashTodayReservations = new Dictionary<int, int>();
            foreach (var res in reservationForWeekChart)
            {
                hashTodayReservations.Add(res.Key, res.Sum(e => e.NrPers));
            }
            if (reservationForWeekChart.Count() < 1)
            {
                hashTodayReservations.Add(0, 0);
            }

            string chart2Values = string.Join(", ",
          hashTodayReservations.Select(d => "[" +  d.Key+ ", " + d.Value + ", color]"));

            // for chart3 
            var allReservations = repository.GeAlltReservations().Where(e=>e.Passed.Equals(false)).OrderBy(e=>e.Date.DayOfWeek).GroupBy(e => e.Date.DayOfWeek.ToString());
            Dictionary<string, int> allRestaurantsReservations = new Dictionary<string, int>();
            foreach(var res in allReservations)
            {
                allRestaurantsReservations.Add(res.Key, res.Sum(e=>e.NrPers) );
            }
            string chart3Values = string.Join(", ",
          allRestaurantsReservations.Select(d => "[" + d.Key + ", " + d.Value + ", color]"));
           
            ViewData["CurrentHour"] = currentHour;
            ViewData["RestaurantName"] = restaurant.RestaurantName;
            ViewData["RestaurantID"] = restaurant.RestaurantID;
            ViewData["RestaurantOpen"] = restaurant.openHour;
            ViewData["RestaurantClose"] = restaurant.closingHour;
            ViewData["RestaurantDesc"] = restaurant.Description;
            ViewData["RestaurantCapacity"] = restaurant.nrPersMax;
            ViewData["RestaurantID"] = restaurant.RestaurantID;


            ViewBag.chartData = array;
            ViewBag.chart2Data = chart2Values;
            ViewBag.chart3Data = chart3Values;

            MyBusinessViewModel model = new MyBusinessViewModel
            {
                Reservations = reservations.Skip((page - 1) * PageSizeReservations).Take(PageSizeReservations),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSizeReservations,
                    TotalItems = reservations.Count()
                }
            };

            return View(model);
        }

       
    }
}
