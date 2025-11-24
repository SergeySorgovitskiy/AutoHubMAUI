using AutoHub.MVVM.Models;

namespace AutoHub.Services.AppMemoryStore
{
    public class Store
    {
        public List<UserModel> Users { get; } = new(); 
        public List<ListingModel> Listings { get; } = new();
        public Store()
        {
            Listings.AddRange(new List<ListingModel>
            {
                new ListingModel
                {
                    Id = 1,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    Description = "A true time capsule. This 1993 W124 is an investment-grade example of the legendary 'Panzer' sedan, built at the peak of Mercedes-Benz's 'over-engineered' era. With only 28,000 documented original miles, this car is arguably one of the cleanest, lowest-mileage examples left in the country. It has been meticulously preserved in a climate-controlled collection. The paint is all-original, and the interior is flawless, showing virtually no wear. It drives as it did the day it left the showroom. A rare opportunity for the serious Mercedes-Benz collector.",
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 2,
                    Title = "BMW 330i xDrive",
                    Subtitle = "Automatic, AWD",
                    Price = 24500,
                    Mileage = 42000,
                    Location = "Seattle, WA",
                    ImageUrl = "bmw.jpg",
                    IsElectric = false,
                     DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 3,
                    Title = "Toyota RAV4 LE",
                    Subtitle = "Automatic, 4WD",
                    Price = 21900,
                    Mileage = 36000,
                    Location = "Austin, TX",
                    ImageUrl = "rav4.jpg",
                    IsElectric = true,
                     DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 4, 
                    Title = "Ford F-150 XLT",
                    Subtitle = "Automatic, 4WD",
                    Price = 27400,
                    Mileage = 58000,
                    Location = "Denver, CO",
                    ImageUrl = "ford.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 5,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 6,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },new ListingModel
                {
                    Id = 7,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                }

            });
            
            Users.Add(new UserModel
            {
                Id = 1,
                Name = "Admin",
                Email = "admin@mail.ru",
                Password = "Lololos28!",
                PhoneNumber = "1234567890",
            });
        }
    }
}
