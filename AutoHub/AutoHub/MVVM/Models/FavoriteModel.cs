using SQLite;

namespace AutoHub.MVVM.Models
{
    [Table("Favorites")]
    public class FavoriteModel
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        [Indexed]
        public int UserId { get; set; }
        [Indexed]
        public int ListingId { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now;
    }
}
