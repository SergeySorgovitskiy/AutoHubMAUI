namespace AutoHub.MVVM.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber {  get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ProfileImageUrl { get; set; } = "default_profile_image.jpg";
        public List<int> FavoriteCarIds { get; set; } = new();

    }
}
