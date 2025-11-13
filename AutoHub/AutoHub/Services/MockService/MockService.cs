using AutoHub.MVVM.Models;

namespace AutoHub.Services.MockService
{

    public class MockService : IMockService
    {
     
        private readonly List<CarListingModel> _cars;
        public MockService()
        {
            _cars = new List<CarListingModel>
            {
                new CarListingModel
                {
                    Id = 1,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg", 
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new CarListingModel
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
                new CarListingModel
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
                new CarListingModel
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
                new CarListingModel
                {
                    Id = 1,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new CarListingModel
                {
                    Id = 1,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                },
                new CarListingModel
                {
                    Id = 1,
                    Title = "Mercedes-Benz W124",
                    Subtitle = "Automatic, RWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = false,
                    DetailsImagesUrls = new List<string> { "interior.jpg", "details1.jpg", "details2.jpg" }
                }
            };
        }
        public async Task<List<CarListingModel>> GetListingsAsync()
        {
            await Task.Delay(500); 
            return _cars;
        }
        public async Task<CarListingModel> GetDetailsByIdAsync(int carId)
        {
            await Task.Delay(200); 
            
            return _cars.FirstOrDefault(c => c.Id == carId);
        }
    }
}