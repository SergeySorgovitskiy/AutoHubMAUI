using CommunityToolkit.Mvvm.ComponentModel;

namespace AutoHub.MVVM.Models
{
    public partial class ListingModel : ObservableObject
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string? Title { get; set; }
        public string? Subtitle { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public int Mileage { get; set; }
        public string? Location { get; set; }
        public bool IsElectric { get; set; }
        public string? Description { get; set; }
        public List<string>? DetailsImagesUrls { get; set; }
        public int SellerUserId { get; set; }

        [ObservableProperty]
        private bool _isFavorite;
    }
}
