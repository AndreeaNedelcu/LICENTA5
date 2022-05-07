using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LICENTA5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
            .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Restaurants.Any())
            {
                context.Restaurants.AddRange(
                new Restaurant
                {
                    RestaurantName = "Paine si Vin",
                    Description = "Pâine si Vin translates to bread and wine, which is quite literally the menu- different selections of crusts from around the world (served similar to flatbread pizza) with your choice of toppings and an impressive selection of wines.",

                    Type = "Mixed",
                    nrPersMax = 90,
                    openHour = 8,
                    closingHour = 23,
                    EmptySeats=90


                },
                new Restaurant
                {
                    RestaurantName = "La Mama",
                    Description = "This place is a great starting point if you’ve never tried Romanian food before, as they have menus available in English as well as Romanian, and the friendly waitstaff is happy to explain menu items to you and make suggestions.",

                    Type = "Romanian",
                    nrPersMax = 74,
                    openHour = 11,
                    closingHour = 24,
                    EmptySeats = 74


                },
                new Restaurant
                {
                    RestaurantName = "Costelaria",
                    Description = "Coetelaria literally translates to 'rib place'. This restaurant is famous for serving the best ribs in all of Bucharest.The restaurant has a large and impressive menu featuring steaks and fish, but we went for the dish they’re most known for the ribs. I shared a platter of beef, pork, and lamb ribs with a side of homemade potato chips.This place is a can’t miss for any meat eaters visiting Bucharest!",

                    Type = "American",
                    nrPersMax = 60,
                    openHour = 10,
                    closingHour = 23,
                    EmptySeats = 60


                },
                new Restaurant
                {
                    RestaurantName = "Maize",
                    Description = "The restaurant is a farm-to-table concept focusing on new Romanian cuisine, or updated traditional recipes done very high end.",

                    Type = "Romanian",
                    nrPersMax = 60,
                    openHour = 10,
                    closingHour = 23,
                    EmptySeats = 60


                },

            new Restaurant
            {
                RestaurantName = "Supapa",
                Description = "The menu features Romanian comfort foods done well. The atmosphere is friendly and relaxed and makes you want to linger. The menu also features a nice selection of local wines and craft beers. Make sure to try one of the freshly made soups!",

                Type ="Romanian",
                nrPersMax = 76,
                openHour = 8,
                closingHour = 21,
                EmptySeats = 76


            },
new Restaurant
{
    RestaurantName = "Borsalino",
    Description = "The restaurant features a large selection of pasta, pizzas, and antipasta. The servings were large and fresh, and the waitstaff was all helpful with making selections. If you’re in Bucharest and craving Italian food, this is definitely the place to go.",

    Type = "Italian",
    nrPersMax = 70,
    openHour = 9,
    closingHour = 24,
    EmptySeats = 70


},
new Restaurant
{
    RestaurantName = "Chocolat",
    Description = "The breakfast is huge, so make sure you come hungry for this one: your choice of tea or coffee, salad, bread, cheeses, butter, sausages, and cured meats. ",

    Type = "Mixed",
    nrPersMax = 68,
    openHour = 9,
    closingHour = 22,
    EmptySeats = 68

},
new Restaurant
{
    RestaurantName = "Shift Pub",
    Description = "All of the portions are generous and the friendly waitstaff is happy to help you with the menu. During good weather try for a seat in the gorgeous garden.",

    Type ="Mixed",
    nrPersMax = 90,
    openHour = 10,
    closingHour = 22 ,
    EmptySeats = 90

},
new Restaurant
{
    RestaurantName = "Blue Margarita",
    Description = "The menu is updated interpretations of traditional South American dishes. The young chef is creative and passionate and you can tell a lot of thought has gone into his menu.",

    Type = "American",
    nrPersMax=60,
    openHour=9,
    closingHour=22,
    EmptySeats = 60


}
);
         context.SaveChanges();
            }
        }
    }
}
