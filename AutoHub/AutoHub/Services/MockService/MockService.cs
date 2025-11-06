using AutoHub.MVVM.Models;

namespace AutoHub.Services.MockService
{
    public class MockService : IMockService
    {
        public async Task<List<CarListingModel>> GetListingsAsync()
        {
            await Task.Delay(1000);

            return new List<CarListingModel>
            {
                new CarListingModel
                {
                    Id = 1,
                    Title = "Tesla Model 3",
                    Year = 2021,
                    Subtitle = "Long Range • AWD",
                    Price = 32900,
                    Mileage = 28000,
                    Location = "San Jose, CA",
                    ImageUrl = "car.jpg",
                    IsElectric = true
                },
                new CarListingModel
                {
                    Id = 2,
                    Title = "BMW 330i xDrive",
                    Year = 2021,
                    Subtitle = "Automatic • 42k mi",
                    Price = 24500,
                    Mileage = 42000,
                    Location = "Seattle, WA",
                    ImageUrl = "car.jpg",
                    IsElectric = false
                },
                new CarListingModel
                {
                    Id = 3,
                    Title = "Toyota RAV4 LE",
                    Year = 2021,
                    Subtitle = "FWD • 36k mi",
                    Price = 21900,
                    Mileage = 36000,
                    Location = "Austin, TX",
                    ImageUrl = "car.jpg",
                    IsElectric = false
                },
                new CarListingModel
                {
                    Id = 4,
                    Title = "Ford F-150 XLT",
                    Year = 2021,
                    Subtitle = "4x4 • 58k mi",
                    Price = 27400,
                    Mileage = 58000,
                    Location = "Denver, CO",
                    ImageUrl = "car.jpg",
                    IsElectric = false
                }

            };

    }
    }
}
