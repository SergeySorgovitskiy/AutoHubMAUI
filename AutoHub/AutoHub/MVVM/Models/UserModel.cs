using SQLite;
namespace AutoHub.MVVM.Models
{
    [Table("Users")]
    public class UserModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(255), Unique]
        public string Email { get; set; } = string.Empty;

        [MaxLength(20)]
        public string PhoneNumber {  get; set; } = string.Empty;

        [MaxLength(255)]
        public string Password { get; set; } = string.Empty;

        public DateTime JoinedDate { get; set; } = DateTime.Now;

        [MaxLength(500)]
        public string ProfileImageUrl { get; set; } = "default_profile_image.jpg";

    }
}
