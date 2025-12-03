using CommunityToolkit.Mvvm.ComponentModel;
using SQLite;
using System.Text.Json;

namespace AutoHub.MVVM.Models
{
    [Table("Listings")]
    public partial class ListingModel : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Year { get; set; }

        [MaxLength(200)]
        public string? Title { get; set; }

        [MaxLength(100)]
        public string? Subtitle { get; set; }
        public decimal Price { get; set; }

        [MaxLength(500)]
        public string? ImageUrl { get; set; }
        public int Mileage { get; set; }

        [MaxLength(200)]
        public string? Location { get; set; }
        public bool IsElectric { get; set; }

        [MaxLength(5000)]
        public string? Description { get; set; }

        [MaxLength(2000)]
        public string? DetailsImagesUrlsJson { get; set; }

        [Ignore]
        public List<string> DetailsImagesUrls
        {
            get
            {
                if(string.IsNullOrEmpty(DetailsImagesUrlsJson))
                    return new List<string>();

                try
                {
                    return JsonSerializer.Deserialize<List<string>>(DetailsImagesUrlsJson) ?? new List<string>();
                }
                catch
                {
                    return new List<string>();
                }
            }
            set
            {
                DetailsImagesUrlsJson = value != null && value.Count > 0 ? JsonSerializer.Serialize(value) : null;
            }
        }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? UpdatedDate { get; set; }

        [Indexed]
        public int SellerUserId { get; set; }

        [ObservableProperty]
        private bool _isFavorite;
    }
}
