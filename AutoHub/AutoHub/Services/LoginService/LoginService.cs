using AutoHub.MVVM.Models;
using AutoHub.Services.Repositories.UserRepository;

namespace AutoHub.Services.LoginService
{
    public class LoginService(
            IUserRepository userRepository) : ILoginService
    {
        public UserModel? CurrentUser { get; private set; }
        public async Task<UserModel?> LoginAsync(string email, string password)
        {
           
            var user = await userRepository.GetUserAsync(email, password);

            if (user != null)
            {
                CurrentUser = user;
            }

            return user;
        }

        public Task LogoutAsync()
        {
            CurrentUser = null;
            return Task.CompletedTask;
        }
    }
}
