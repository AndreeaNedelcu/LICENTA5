using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LICENTA5.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using LICENTA5.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using LICENTA5.Areas.Identity.Data;
using System.Security.Claims;
using LICENTA5.Areas.Identity.Pages.Account;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using Microsoft.ML;

namespace LICENTA5.Controllers
{
   [Authorize]
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly UserManager<ApplicationUser> _userManager;
        private IStoreRepository repository;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<ApplicationUser> _signInManager;
        ILogger<LoginModel> _logger2;
        public int PageSize = 4;
        public int PageSizeReservations = 3;
       
        public HomeController(ILogger<HomeController> logger, 
            IStoreRepository repo,
            IHostingEnvironment hostingEnvironment,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, ILogger<LoginModel> logger2)
        {
            _logger = logger;
            repository = repo;
            this.hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger2 = logger2;
            _httpClient = new HttpClient()
            {
                Timeout = TimeSpan.FromSeconds(5)
            };
        }



        [HttpGet]
        public async Task<string> GetCurrentUserId()
        {
            ApplicationUser usr = await GetCurrentUserAsync();
            return usr?.Id;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

    
        private double distance(double lat1, double lon1, double lat2, double lon2)
        {
            int minutesInADegree = 60;
            double nauticalMile = 1.1515;
            double theta = lon1 - lon2;
            double dist = Math.Sin(deg2rad(lat1))
                            * Math.Sin(deg2rad(lat2))
                            + Math.Cos(deg2rad(lat1))
                            * Math.Cos(deg2rad(lat2))
                            * Math.Cos(deg2rad(theta));
            dist = Math.Acos(dist);
            dist = rad2deg(dist);
            dist = dist * minutesInADegree * nauticalMile;
            return (dist);
        }

        private double deg2rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }

        private double rad2deg(double rad)
        {
            return (rad * 180.0 / Math.PI);
        }

        public string RandomString(int size, bool lowerCase = false)
        {
            Random _random = new Random();
        var builder = new StringBuilder(size);
 
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; 

            for (var i = 0; i < size; i++)
            {
                var character = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(character);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        [AllowAnonymous]
        public async Task<IActionResult> IndexAsync(string? searchTerm)
        {
            var displaydata = repository.Search(searchTerm).ToList();
            //Recommend();
            Random rand = new Random();
            int toSkip = rand.Next(1, repository.Restaurants.Count());
            Restaurant res = null;

               res = repository.Restaurants.Where(e=>e.Confirmed.Equals(true)).Skip(toSkip).Take(1).FirstOrDefault();
            IndexViewModel model = null;

            GeoInfoProvider geoInfoProvider = new GeoInfoProvider();
            var latitude = 0.0;
            var longitud = 0.0;
            var restaurants = repository.Restaurants;
            var minDistance = 9999.999;
            var closestRestaurant = new Restaurant();
            if (CheckForInternetConnection()) {
                var ipAddress = await geoInfoProvider.GetIPAddress();

                var response = await _httpClient.GetAsync($"http://api.ipstack.com/" + ipAddress + "?access_key=181601ebb5b10caa7cac2b391e8a23e7");
                var locatioNinfo = new GeoInfoViewModel();
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    locatioNinfo = JsonConvert.DeserializeObject<GeoInfoViewModel>(json);
                }

               
                if (locatioNinfo != null)
                {
                    latitude = Decimal.ToDouble(locatioNinfo.Latitude);
                    longitud = Decimal.ToDouble(locatioNinfo.Longitude);
                   
                }
                
            }
            else
            {
                //ViewBag.ErrorTitle = "Connection issue";
                //ViewBag.ErrorMessage = "We do not have access to your current location";
                //return View("Error");
            }

            foreach (var restaurant in restaurants.Where(e=> e.Confirmed.Equals(true)))
            {
                var dist = distance(latitude, longitud, restaurant.Latitude, restaurant.Longitude);
                if (dist < minDistance)
                {
                    minDistance = dist;
                    closestRestaurant = restaurant;
                }
            }

            var maxReservations = 0;
            var mostPopularRestaurant = new Restaurant();
            foreach(var restaurant in restaurants.Where(e=>e.Confirmed.Equals(true)))
            {
                var noOfReservations = repository.GetReservationsAtRestaurant(restaurant.RestaurantID).Count();
                if(noOfReservations> maxReservations)
                {
                    maxReservations = noOfReservations;
                    mostPopularRestaurant = restaurant;
                }
            }
            model = new IndexViewModel
            {
                RestaurantsList = displaydata,
                SearchTerm = searchTerm,
                RandomRestaurant = res,
                NearestRestaurant = closestRestaurant,
                MostPopularRestaurant=mostPopularRestaurant

                };
            ViewBag.lat = latitude;
            getPremiumFeatures();
            return View(model);
        }
       

        [AllowAnonymous]
        public IActionResult AboutUs()
        {
            getPremiumFeatures();
            return View();
        }
        [AllowAnonymous]
        public ViewResult Restaurants(string type, int page = 1) {


            RestaurantsListViewModel model = new RestaurantsListViewModel
            {
                Restaurants = repository.Restaurants
                .Where(p => type == null || p.Type == type)
            .OrderBy(p => p.RestaurantID)
            .Skip((page - 1) * PageSize)
            .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = type == null ?
repository.Restaurants.Count() :
repository.Restaurants.Where(e =>
e.Type == type).Count()
                },
                CurrentCategory = type
            };
            ViewBag.Category = model.CurrentCategory;

            return View(model);
        }
        [Authorize]
        public ViewResult CreateBooking()
        {
            getPremiumFeatures();
            return View();
        }

        public void ChangePremiumOffers()
        {
            var today = DateTime.Now;
            Random rand = new Random();
            int toSkip = rand.Next(1, repository.Restaurants.Count() - 5);


            Restaurant[] restaurantsRandom = repository.Restaurants.Skip(toSkip).Take(5).ToArray();

            Restaurant res1 = restaurantsRandom[0];
            Restaurant res2 = restaurantsRandom[1];
            Restaurant res3 = restaurantsRandom[2];
            Restaurant res4 = restaurantsRandom[3];

            var codeBuilder = new StringBuilder();
            codeBuilder.Append(RandomString(7));
            var codeBuilder1 = new StringBuilder();
            codeBuilder1.Append(RandomString(7));
            var codeBuilder2 = new StringBuilder();
            codeBuilder2.Append(RandomString(7));
            var codeBuilder3 = new StringBuilder();
            codeBuilder3.Append(RandomString(7));

            PremiumOffer offer1 = new PremiumOffer
            {
                Today = today,
                Offer = "A free coffee at " + res1.RestaurantName,
                Code = codeBuilder.ToString(),
                RestaurantName=res1.RestaurantName
            };
            PremiumOffer offer2 = new PremiumOffer
            {
                Today = today,
                Offer = "50% voucher at " + res2.RestaurantName,
                Code = codeBuilder1.ToString(),
                RestaurantName=res2.RestaurantName
            };
            PremiumOffer offer3 = new PremiumOffer
            {
                Today = today,
                Offer = "A free drink at " + res3.RestaurantName,
                Code = codeBuilder2.ToString(),
                RestaurantName=res3.RestaurantName
            };
            PremiumOffer offer4 = new PremiumOffer
            {
                Today = today,
                Offer = "20% voucher for food at " + res4.RestaurantName,
                Code = codeBuilder3.ToString(),
                RestaurantName=res4.RestaurantName
            };

            repository.AddPremiumOffer(offer1);
            repository.AddPremiumOffer(offer2);
            repository.AddPremiumOffer(offer3);
            repository.AddPremiumOffer(offer4);
        }

        [Authorize]
        public async Task<IActionResult> YourReservationsAsync(string? sortOrder, int page=1)
        {
            int pageSize = 3;
         
            var modelReservations = repository.GetReservations(await GetCurrentUserId()).Where(e => e.Passed.Equals(false));
            ApplicationUser user = await _userManager.GetUserAsync(HttpContext.User);

            ViewData["DateSortParm"] = sortOrder == "Date" ? "date" : "Date";
            switch (sortOrder)
            {

                case "Date":
                    modelReservations = modelReservations.OrderBy(s => s.Date);
                    break;
                case "date_desc":
                    modelReservations = modelReservations.OrderByDescending(s => s.Date);
                    break;
                default:
                    modelReservations = modelReservations.OrderBy(s => s.ReservationId);
                    break;
            }
            if (repository.GetReservations(await GetCurrentUserId()).Count() >10)
            {
                await _userManager.AddToRoleAsync(user, "Premium-User");
            }

            DateTime currentDate = DateTime.Now;
            int currentHour = currentDate.Hour;
          
            ViewBag.CurrentHour = currentHour;
            ViewBag.CurrentDate = currentDate;

            foreach (var i in modelReservations.ToList())
            {
                DateTime reservationRealDate = new DateTime(i.Date.Year, i.Date.Month, i.Date.Day, i.HourComing, currentDate.Minute, currentDate.Second);

                var restaurant = repository.GetRestaurant((int)i.RestaurantId);
                if (currentDate.AddHours(1) > reservationRealDate)
                {
                   
                    if (restaurant != null) {
                        restaurant.EmptySeats += i.NrPers;
                        repository.Update(restaurant);
                        i.Passed = true;
                        repository.Update(i, await GetCurrentUserId());
                      
                    }
                        
                }
            }
            
            YourReservationsViewModel model = new YourReservationsViewModel
            {
                Reservations = modelReservations.Skip((page - 1)*PageSizeReservations).Take(PageSizeReservations),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSizeReservations,
                    TotalItems = modelReservations.Count()
                }
            };
            getPremiumFeatures();
   
            return View(model);
        }

        public void getPremiumFeatures()
        {
            var today = DateTime.Now;
            var premiumOffersData = repository.GetOffers();
            if (premiumOffersData.Count() == 0)
            {
                ChangePremiumOffers();
            }
            else if (!(today.ToShortDateString().Equals(repository.GetOffers().First().Today.ToShortDateString())))
            {
                List<PremiumOffer> currentOffers = repository.GetOffers().ToList();
                foreach (var o in currentOffers)
                {
                    repository.DeletePremiumOffer(o.Id);
                }
                ChangePremiumOffers();
            }

            var offers = repository.GetOffers();
            List<string> premiumFeatures = new List<string>();
            List<string> voucherCodes = new List<string>();
            foreach (PremiumOffer o in offers)
            {
                premiumFeatures.Add(o.Offer);
                voucherCodes.Add(o.Code);
            }

            ViewBag.listFeatures = premiumFeatures;
            ViewBag.listCodes = voucherCodes;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {getPremiumFeatures();
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       

        [HttpGet]
        [Authorize(Roles ="Admin, User, Premium-User")]
        public ViewResult AddRestaurant()
        {
            getPremiumFeatures();
            ViewData["MyKeyMaps"] = "AIzaSyDq_B5S5fvlG2VbaEYRDkG59Wc7pjs4ZbQ";
            return View();
        }


        [HttpPost]
        [Authorize(Roles = "Admin, User, Premium-User")]
        public async Task<IActionResult> AddRestaurantAsync(RestaurantCreateViewModel model)
        {
            
            if (ModelState.IsValid)
            {if (model.Type == "0")
                    model.Type = "American";
            else if (model.Type == "1")
                    model.Type = "Italian";
                else if (model.Type == "2")
                    model.Type = "Mixed";
                else if (model.Type == "3")
                    model.Type = "Romanian";
                else
                    if (model.Type == "4")
                    model.Type = "Chineese";
                else
                    if (model.Type == "5")
                    model.Type = "Spanish";
                else
                    if (model.Type == "6")
                    model.Type = "Mexican";

                string uniqueFileName = null;
                float lat = 0;
                float lng = 0;
            
                if (model.Photo != null)
                {
                    string folder = "images";
                    uniqueFileName = UploadImage(folder,model.Photo );
                }

                
                if (model.GalleryFiles != null)
                {
                    string folder = "images";
                    model.Gallery = new List<GalleryModel>();
                    if(model.GalleryFiles.Count() >0)
                    {
                        foreach (var file in model.GalleryFiles)
                        {
                            var gallery = new GalleryModel()
                            {
                                Name = file.FileName,
                                URL = UploadImage(folder, file)

                            };
                            model.Gallery.Add(gallery);
                        }
                    }
                   
                }
                if((model.Latitude !=null || model.Latitude != 0) && (model.Longitude !=null || model.Longitude !=0))
                {
                     lat = model.Latitude;
                     lng = model.Longitude;
                    

                }
              
                else
                {
                     lat = 44.4267674f;
                     lng = 26.1025384f;
                }

              
                Restaurant newRest = new Restaurant
                {
                    RestaurantName = model.RestaurantName,
                    Description = model.Description,
                    Type = model.Type,
                    nrPersMax = model.nrPersMax,
                    EmptySeats=model.nrPersMax,
                    openHour = model.openHour,
                    closingHour = model.closingHour,
                    PhotoPath = uniqueFileName,
                    Latitude=lat,
                    Longitude=lng,
                    PhoneNo=model.PhoneNo
                    


                };
                if(_signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                {
                    newRest.Confirmed = true;
                }
                else
                {
                    newRest.Confirmed = false;
                }
                newRest.AddedBy = _userManager.GetUserName(User);
                model.AddedBy = newRest.AddedBy;
                model.Confirmed = newRest.Confirmed;
                newRest.RestaurantGallery = new List<RestaurantGallery>();
                if(model.Gallery != null)
                {
                    foreach (var file in model.Gallery)
                    {
                        newRest.RestaurantGallery.Add(new RestaurantGallery()
                        {
                            Name = file.Name,
                            URL = file.URL


                        });
                    }
                }
                getPremiumFeatures();
                ViewData["MyKeyMaps"] = "AIzaSyDq_B5S5fvlG2VbaEYRDkG59Wc7pjs4ZbQ";
                repository.Add(newRest);
                return RedirectToAction("Restaurants", new { id = newRest.RestaurantID });
            }
            return View();
        }

        private string UploadImage(string filePath, IFormFile file)
        {
            string uniqueFileName;
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");

            //append the name of the file
            uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            //model.PhotoURL = uniqueFileName;
              filePath = Path.Combine(uploadsFolder, uniqueFileName);

            file.CopyTo(new FileStream(filePath, FileMode.Create));
            return uniqueFileName;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ViewResult> RestaurantDetailsAsync(int id)
        {
            List<RestaurantRating> RatingList = new List<RestaurantRating>();
            RatingList.Add(new RestaurantRating { Rating = 1, RestaurantId = id });
            RatingList.Add(new RestaurantRating { Rating = 2, RestaurantId = id });
            RatingList.Add(new RestaurantRating { Rating = 3, RestaurantId = id });
            RatingList.Add(new RestaurantRating { Rating = 4, RestaurantId = id });
            RatingList.Add(new RestaurantRating { Rating = 5, RestaurantId = id });


            int Id = (int)id;
            Restaurant restaurant = repository.GetRestaurant(Id);
            if (restaurant == null)
            {
                Response.StatusCode = 404;
                return View("RestaurantNotFound", Id);
            }
            var Ratings = repository.Ratings(restaurant.RestaurantID);
            var SumOfRates = 0;
            foreach (var i in Ratings)
            {
                SumOfRates += i.Rating;
            }
            double finalRate = 0.0;
            finalRate = (double)SumOfRates / Ratings.Count();
            
            ViewData["FinalRate"] = finalRate.ToString("0.0"); 

            RestaurantDetailsViewModel restDetails = new RestaurantDetailsViewModel()
            {
                Restaurant = restaurant,

            };
            restDetails.Gallery = new List<GalleryModel>();
            

            restDetails.Gallery=repository.GetGallery(id).Select(g => new GalleryModel()
            {

                Id = g.Id,
                Name = g.Name,
                URL = g.URL
            }).ToList();
            restDetails.RestaurantRatings = repository.Ratings(id).ToList();

            //if (submit.Equals("5"))
            //{
            //    repository.AddRating(new RestaurantRating { Rating = 5, RestaurantId = restaurant.RestaurantID });
            //}

            //DECOMENTEAZA!!!
            //var userReservations = repository.GetReservations(await GetCurrentUserId()).Where(e => e.Passed.Equals(true && e.RestaurantId.Equals(Id)));
            //if (userReservations.Count() > 0)
            //{
            //    ViewBag.hasReservation = true;
            //}
            //else
            //{
            //    ViewBag.hasReservation = false;
            //}
            ViewBag.hasReservation = true;
            ViewData["MyKeyMaps"] = "AIzaSyDq_B5S5fvlG2VbaEYRDkG59Wc7pjs4ZbQ";
            return View(restDetails);
        }

        [HttpGet]
        [Authorize]
        public async Task<ViewResult> AddBookingAsync(int id)
        {
            int Id = (int)id;
            AddBookingViewModel addBookingViewModel = new AddBookingViewModel()
            {
                ApplicationUser = await  GetCurrentUserAsync(),
               Restaurant= repository.GetRestaurant(Id),
                PageTitle = "Create reservation at "
            };
            getPremiumFeatures();
            ViewBag.open = addBookingViewModel.Restaurant.openHour;
            ViewBag.close = addBookingViewModel.Restaurant.closingHour;
            ViewBag.ReservationAt = addBookingViewModel.Restaurant.RestaurantName;
            ViewBag.OpenHour = addBookingViewModel.Restaurant.openHour;
            return View(addBookingViewModel);
        }

       

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddBookingAsync(AddBookingViewModel model, int id)
        {
            if(model.VoucherCode != null)
            {
                var currentOffers = repository.GetOffers().ToList();
                List<string> currentCodes = new List<string>();
                foreach (var o in currentOffers)
                {
                    currentCodes.Add(o.Code);
                }
                bool isFound = false;
                foreach (var c in currentCodes)
                {
                    if (model.VoucherCode.Equals(c))
                        isFound = true;
                }
                if (isFound == false)
                {
                    ModelState.AddModelError("VoucherCode", "Invalid code");

                }


            }

            if (ModelState.IsValid)
            {
                
                model.ApplicationUser.Id = await GetCurrentUserId();
                model.Restaurant = repository.GetRestaurant(id);
                 Reservation newReservation = new Reservation
                {
                    NrPers = model.NrPers,
                    HourComing = model.HourComing,
                    Date = model.Date,
                    UserId = await GetCurrentUserId(),
                    RestaurantId=model.Restaurant.RestaurantID,
                    VoucherCode=model.VoucherCode
                };
                
                if(model.Restaurant.EmptySeats != 0 && newReservation.NrPers <= model.Restaurant.EmptySeats)
                {
                    model.Restaurant.EmptySeats -= newReservation.NrPers;
                }
                if (newReservation.NrPers > model.Restaurant.EmptySeats)
                {
                   ModelState.AddModelError("NrPers"," Not enough empty seats") ;

                }
                if (newReservation.Date.ToShortDateString().Equals(DateTime.Now.ToShortDateString()) && newReservation.HourComing <= DateTime.Now.Hour)
                {
                    ModelState.AddModelError("Date", "Invalid hour or date");
                    
                }
                if (newReservation.Date.ToShortDateString().Equals(DateTime.Now.ToShortDateString()) && newReservation.HourComing <= DateTime.Now.AddHours(2).Hour)
                {
                    ModelState.AddModelError("HourComing", "Book a table at least 2 hours before");

                }
                var currentUserReservations = repository.GetReservations(await GetCurrentUserId());
                foreach (var res in currentUserReservations)
                {
                    if (newReservation.Date.ToShortDateString().Equals(res.Date.ToShortDateString()) && (newReservation.HourComing.Equals(res.HourComing) || (newReservation.HourComing.Equals(res.HourComing + 1)) || (newReservation.HourComing.Equals(res.HourComing + 2))))
                    {
                        ModelState.AddModelError("Date", "You already have a reservation at this time");
                      
                    }
                }
                if (model.VoucherCode != null)
                {
                    var premiumOffers = repository.GetOffers();
                    Dictionary<string, string> codesForRestaurants = new Dictionary<string, string>();
                    foreach (var o in premiumOffers)
                    {
                        codesForRestaurants[o.Code] = o.RestaurantName;
                    }
                    if (codesForRestaurants[model.VoucherCode] != model.Restaurant.RestaurantName)
                    {
                       
                        ModelState.AddModelError("VoucherCode", "Wrong code");
                    }
                    var reservations = repository.GetReservations(await GetCurrentUserId());
                    foreach (var r in reservations)
                    {
                        if(r.VoucherCode != null)
                        {
                            if (r.VoucherCode.Equals(model.VoucherCode))
                            {
                                ModelState.AddModelError("VoucherCode", "Code already used");
                            }
                        }

                    }
                }
                ViewBag.Restaurant = model.Restaurant;

                if (ModelState.IsValid)
                {
                    repository.AddReservation(newReservation);
                    return RedirectToAction("YourReservations", new { id = newReservation.ReservationId });
                }
            }
            getPremiumFeatures();
            model.Restaurant = repository.GetRestaurant(id);
            ViewBag.ReservationAt = model.Restaurant.RestaurantName;
            ViewBag.SeatsLeft = model.Restaurant.EmptySeats;
            ViewBag.OpenHour = model.Restaurant.openHour;
            return View();
        }


        [HttpGet]
        [Authorize(Roles ="Admin, Business") ]
        public ViewResult EditRestaurant(int id)
        {
            var type = "";
            
            Restaurant restaurant = repository.GetRestaurant(id);
           var Gal= repository.GetGallery((int)restaurant.RestaurantID);

            if (restaurant.Type == "American")
            {
                type = "0";
            }
            else if (restaurant.Type == "Italian")
            {
                type = "1";
            }
            else if (restaurant.Type == "Mixed")
            {
                type = "2";
            }
            else if (restaurant.Type == "Romanian")
            {
                type = "3";
            }
            else if (restaurant.Type == "Chineese")
            {
                type = "4";
            }
            else if (restaurant.Type == "Spanish")
            {
                type = "5";
            }
            else if (restaurant.Type == "Mexican")
            {
                type = "6";
            }
            EditRestaurantViewModel editRestaurantViewModel = new EditRestaurantViewModel
            {
                Id = (int)restaurant.RestaurantID,
                RestaurantName = restaurant.RestaurantName,
                PhoneNo=restaurant.PhoneNo,
                Description = restaurant.Description,
                Type = type,
                nrPersMax = restaurant.nrPersMax,
                EmptySeats=restaurant.nrPersMax,
                openHour = restaurant.openHour,
                closingHour = restaurant.closingHour,
                ExistingPhotoPath = restaurant.PhotoPath,
                ExistingRestaurantGallery=Gal,
                Latitude=restaurant.Latitude,
                Longitude=restaurant.Longitude,
   
            }; 
            getPremiumFeatures();
            ViewBag.ExistingPhoto = editRestaurantViewModel.ExistingPhotoPath;
            return View(editRestaurantViewModel);
        }

        [HttpPost]
        [Authorize(Roles = "Admin, Business")]
        public IActionResult EditRestaurant(EditRestaurantViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.Type == "0")
                    model.Type = "American";
                else if (model.Type == "1")
                    model.Type = "Italian";
                else if (model.Type == "2")
                    model.Type = "Mixed";
                else if (model.Type == "3")
                    model.Type = "Romanian";
                else
                    if (model.Type == "4")
                    model.Type = "Chineese";
                else
                    if (model.Type == "5")
                    model.Type = "Spanish";
                else
                    if (model.Type == "6")
                    model.Type = "Mexican";


                Restaurant restaurant = repository.GetRestaurant(model.Id);
                restaurant.RestaurantName = model.RestaurantName;
                restaurant.Description = model.Description;
                restaurant.Type = model.Type;
                restaurant.nrPersMax = model.nrPersMax;
                restaurant.openHour = model.openHour;
                restaurant.closingHour = model.closingHour;
                restaurant.EmptySeats = model.nrPersMax;
                restaurant.PhoneNo = model.PhoneNo;
                restaurant.Latitude = model.Latitude;
                restaurant.Longitude = model.Longitude;


                string uniqueFileName = null;

                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.
                if (model.Photo != null)
                {
                    if(model.ExistingPhotoPath != null)
                    {
                        string filePath = Path.Combine(hostingEnvironment.WebRootPath,
                  "images", model.ExistingPhotoPath);
                        System.IO.File.Delete(filePath);
                    }
                    string folder = "images";
                    restaurant.PhotoPath = UploadImage(folder, model.Photo);
                }


                if (model.GalleryFiles != null)
                {
                    string folder = "images";
                    if(model.ExistingRestaurantGallery != null)
                    {
                       foreach(var p in model.ExistingRestaurantGallery)
                        {
                            string filePath = Path.Combine(hostingEnvironment.WebRootPath,
                  "images", p.ToString());
                            System.IO.File.Delete(filePath);
                        }
                    }
                   
                    model.Gallery = new List<GalleryModel>();

                    foreach (var file in model.GalleryFiles)
                    {
                        var gallery = new GalleryModel()
                        {
                            Name = file.FileName,
                            URL = UploadImage(folder, file)

                        };
                       
                        model.Gallery.Add(gallery);
                        restaurant.RestaurantGallery = new List<RestaurantGallery>();
                        foreach (var f in model.Gallery)
                        {
                            restaurant.RestaurantGallery.Add(new RestaurantGallery()
                            {
                                Name = f.Name,
                                URL = f.URL
                            });
                        }

                    }
                


                }
                if (_signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                {
                    restaurant.Confirmed = true;
                }
                else
                {
                    restaurant.Confirmed = false;
                }

                    repository.Update(restaurant);
                getPremiumFeatures();
                return RedirectToAction("Restaurants", new { id = restaurant.RestaurantID });
            }
            getPremiumFeatures();
            return View();
        }


        [Authorize(Roles = "Admin, Business")]
       
        public  IActionResult DeleteRestaurant(int id)
        {
            getPremiumFeatures();
            var restaurant = repository.GetRestaurant(id);
            var reservations = repository.GetReservationsAtRestaurant(id).Where(e => e.Passed.Equals(false));
            foreach(var reservation in reservations)
            {
                if (reservation.RestaurantId.Equals(id))
                {
                    ViewBag.ErrorTitle = "Cannot delete";
                    ViewBag.ErrorMessage = "This restaurant has upcoming reservations";
                    return View("Error");
                }
            }
            if (restaurant == null)
            {

                return View("Error");
            }
            else
            {
               
                repository.Delete(id);

                // if (result.Succeeded)
                // {
                // return RedirectToAction("Restaurants");
                //}

                //foreach (var error in result.Errors)
                //{
                //    ModelState.AddModelError("", error.Description);
                //}

                return RedirectToAction("Restaurants");
            }
        }

        [HttpGet]
        [Authorize]
        public async Task<ViewResult> EditReservationAsync(int id)
        {
            string userId = await GetCurrentUserId();
            Reservation reservation = repository.GetReservation(userId, id);
            EditReservationViewModel editReservationViewModel = new EditReservationViewModel
            {
                Id = (int)reservation.ReservationId,
                NrPers = reservation.NrPers,
                HourComing = reservation.HourComing,
                Date = reservation.Date
                
             
            };
            var restaurant = repository.GetRestaurant((int)reservation.RestaurantId);
            ViewBag.ReservationAt = restaurant.RestaurantName;
            ViewBag.SeatsLeft = restaurant.EmptySeats;
            ViewBag.OpenHour = restaurant.openHour;
            getPremiumFeatures();
            return View(editReservationViewModel);
        }



        [HttpPost]
        public async Task<IActionResult> EditReservationAsync(EditReservationViewModel model)
        {
            string userId = await GetCurrentUserId();
            if (ModelState.IsValid)
            {
          
                  
                Reservation reservation = repository.GetReservation(userId, model.Id);
                Restaurant res = repository.GetRestaurant((int)reservation.RestaurantId);
                if (reservation.NrPers.Equals(model.NrPers))
                {
                    reservation.NrPers = model.NrPers;
                }
                else if (reservation.NrPers > model.NrPers)
                {
                    reservation.NrPers = model.NrPers;
                    res.EmptySeats += reservation.NrPers - model.NrPers;
                }
                else if(reservation.NrPers < model.NrPers)
                {
                    if (res.EmptySeats < model.NrPers-reservation.NrPers)
                    {
                        ViewBag.ErrorTitle = "Not enough seats";
                        ViewBag.ErrorMessage = "We are very sorry for the inconvenience, but there are not enough seats for your reservation. Try to go back and see how many seats are left";
                        return View("Error");
                    }
                    else
                    {
                        res.EmptySeats -= model.NrPers - reservation.NrPers;
                        reservation.NrPers = model.NrPers;
                        
                    }

                }

               
                ViewBag.ReservationAt = res.RestaurantName;
                reservation.HourComing = model.HourComing;
                   reservation.Date = model.Date;


               
               // res.EmptySeats = model.NrPers;
               
              
                repository.Update(reservation, userId);
                repository.Update(res);
                return RedirectToAction("YourReservations", new { id = reservation.ReservationId });
            }
            getPremiumFeatures();
            Reservation reservation2 = repository.GetReservation(userId, model.Id);
            Restaurant res2 = repository.GetRestaurant((int)reservation2.RestaurantId);
            ViewBag.ReservationAt = res2.RestaurantName;
            return View();
        }

        //[HttpDelete]
        //[Authorize]
        public async Task<IActionResult> DeleteReservationAsync(int id)
        {
            getPremiumFeatures();
            string userId = await GetCurrentUserId();
            var reservation = repository.GetReservation(userId, id);
            var restaurant = repository.GetRestaurant((int)reservation.RestaurantId);
            

            if (reservation == null)
            {

                return View("Error");
            }
            else
            {
                restaurant.EmptySeats += reservation.NrPers;
                repository.Update(restaurant);
                repository.DeleteReservation(id);

                return RedirectToAction("YourReservations");
            }

        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> RestaurantDetails(RestaurantDetailsViewModel model,  int id)
        {

            if (ModelState.IsValid)
            {
                model.Restaurant = repository.GetRestaurant(id);
                Restaurant res = model.Restaurant;

                if (Request.Form["submit"].Count() > 0) {
                    int rate = Int16.Parse(Request.Form["submit"].First().ToString());
                    repository.AddRating(new RestaurantRating { Rating = rate,userId=await GetCurrentUserId(), RestaurantId = model.Restaurant.RestaurantID });
                }

                var Ratings = repository.Ratings(res.RestaurantID);
                var SumOfRates = 0;
                foreach(var i in Ratings)
                {
                    SumOfRates += i.Rating;
                }
                double finalRate = SumOfRates / Ratings.Count();
                
                //DECOMENTEAZA !!!!!!!!!!!!!1
                //var userReservations = repository.GetReservations(await GetCurrentUserId()).Where(e => e.Passed.Equals(true && e.RestaurantId.Equals(model.Restaurant.RestaurantID)));
                //if (userReservations.Count()<0 || userReservations==null)
                //{
                //    ModelState.AddModelError("", "You don't have previous reservations at this restaurant");
                //}

                
                ViewData["FinalRate"] = finalRate.ToString("0.0");
                return RedirectToAction("RestaurantDetails", new { id = res.RestaurantID });
            }
           


            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult ExternalLogin(string provider, string returnUrl)
        {
            var redirectUrl = Url.Action("ExternalLoginCallback", "Home",
                                new { ReturnUrl = returnUrl });
            var properties = _signInManager
                .ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return new ChallengeResult(provider, properties);
        }

        [AllowAnonymous]
        public async Task<IActionResult>
              ExternalLoginCallback(string returnUrl = null, string remoteError = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            LoginModel loginViewModel = new LoginModel(_signInManager, _logger2, _userManager)
            {
                ReturnUrl = returnUrl,
                ExternalLogins =
                        (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };

            if (remoteError != null)
            { 
                ModelState
                    .AddModelError(string.Empty, $"Error from external provider: {remoteError}");

                return View("Login", loginViewModel);
            }

            // Get the login information about the user from the external login provider
            var info = await _signInManager.GetExternalLoginInfoAsync();
              if (info == null)
            {
                ModelState
                    .AddModelError(string
                     .Empty, "Error loading external login information.");

                return View("Login", loginViewModel);
            }

            // If the user already has a login (i.e if there is a record in AspNetUserLogins
            // table) then sign-in the user with this external login provider
            var signInResult = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider,
                info.ProviderKey, isPersistent: false, bypassTwoFactor: true);

            if (signInResult.Succeeded)
            {
                return LocalRedirect(returnUrl);
            }
            // If there is no record in AspNetUserLogins table, the user may not have
            // a local account
            else
            {
                // Get the email claim value
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);

                if (email != null)
                {
                    // Create a new user without password if we do not have a user already
                    var user = await _userManager.FindByEmailAsync(email);

                    if (user == null)
                    {
                        user = new ApplicationUser
                        {
                            UserName = info.Principal.FindFirstValue(ClaimTypes.Email),
                            Email = info.Principal.FindFirstValue(ClaimTypes.Email)
                        };

                        await _userManager.CreateAsync(user);
                    }

                    // Add a login (i.e insert a row for the user in AspNetUserLogins table)
                    await _userManager.AddLoginAsync(user, info);
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return LocalRedirect(returnUrl);
                }

                // If we cannot find the user email we cannot continue
                ViewBag.ErrorTitle = $"Email claim not received from: {info.LoginProvider}";
                ViewBag.ErrorMessage = "Please contact us.";

                return View("Error");
            }


        }

       

        [HttpGet]
        public IActionResult BuyGiftCard()
        {
            getPremiumFeatures();
            return View();
        }

       

        [HttpPost]
        
        public IActionResult BuyGiftCard(GiftCard card)
        {
            if (ModelState.IsValid)
            {
                GiftCard giftCard = new GiftCard
                {
                    CardValue=card.CardValue,
                    ReceiverEmail=card.ReceiverEmail,
                    SenderFullName=card.SenderFullName,
                    SenderCardNo=card.SenderCardNo,
                    ExpirationDate=card.ExpirationDate,
                    SenderCVV=card.SenderCVV,
                    Message=card.Message
                };
                repository.AddGiftCard(card);

                using (MailMessage mm = new MailMessage("flashtable0@gmail.com", card.ReceiverEmail))
                {
                    mm.Subject = "Flash Table Gift Card";
                    using (MemoryStream ms = new MemoryStream())
                    {
                        QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                        QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(card.GiftCardID+card.SenderFullName, QRCodeGenerator.ECCLevel.Q);
                        QRCode qRCode = new QRCode(qRCodeData);
                        using (Bitmap bitmap = qRCode.GetGraphic(20))
                        {
                            bitmap.Save(ms, ImageFormat.Png);
                             bitmap.Save("OR_Voucher_Code", ImageFormat.Png);
                           // bitmap.Save("OR_Voucher_Code", ImageFormat.Jpeg);
                           // ViewData["QRCODE"] = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                            // mm.Body = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                        }
                        string filename = Path.GetFileName("OR_Voucher_Code");
                        mm.Attachments.Add(new Attachment(ms, filename));
                        bool hasMessage = false;
                        if (card.Message != null)
                        {
                            mm.Body = "Your friend " + card.SenderFullName  + "  sent you a gift card.\n" + "You also have the following message: " + card.Message + "\nThe value of the gift card is " + card.CardValue +
                                "  and it is valid between " + DateTime.Now.ToShortDateString()
                           + "-" + DateTime.Now.AddMonths(6).ToShortDateString() + "\nWe are looking forward to meet you in one of our partner restaurants!";
                        } 
                        else
                        {
                            mm.Body = "Your friend " + card.SenderFullName + "sent you a gift card. \n The value of the gift card is " + card.CardValue + "and it is valid between " + DateTime.Now.ToShortDateString()
                           + "-" + DateTime.Now.AddMonths(6).ToShortDateString() + "\nWe are looking forward to meet you in one of our partner restaurants!";
                        }
                        mm.IsBodyHtml = false;
                        using (SmtpClient smtp = new SmtpClient())
                        {
                            smtp.Host = "smtp.gmail.com";
                            smtp.EnableSsl = true;
                            NetworkCredential credentials = new NetworkCredential("flashtable0@gmail.com", "Fecioara27");
                            smtp.UseDefaultCredentials = true;
                            smtp.Credentials = credentials;
                            smtp.Port = 587;
                            smtp.Send(mm);

                        }
                    }
                }

                return RedirectToAction("GiftCardSuccess");
            }
            getPremiumFeatures();
            ViewBag.ErrorTitle = "Oops... Something went wrong";
            ViewBag.ErrorMessage = "It seems like there was a problem with your data, try again.";
            return RedirectToAction("Error");
        }


        public IActionResult GiftCardSuccess()
        {

            return View();
        }


        public async Task RecommendAsync()
        {
            var activeUser = await GetCurrentUserAsync();
            MLContext mlContext = new MLContext();


            List<(int restId, float normalizedScore)> ratings = new List<(int restId, float normalizedScore)>();
            var PreviousReservations = repository.GetReservations(await GetCurrentUserId()).Where(e => e.Passed.Equals(true));
            

            //Define DataViewSchema for data preparation pipeline and trained model
            DataViewSchema modelSchema;

            // Load trained model
            ITransformer trainedModel = mlContext.Model.Load("Data/RestaurantRecommenderModel.zip", out modelSchema);
           // return View();
        }


    }


}

