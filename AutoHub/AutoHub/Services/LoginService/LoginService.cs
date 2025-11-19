using AutoHub.MVVM.Models;
using AutoHub.Services.Repositories.UserRepository;

namespace AutoHub.Services.LoginService
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepository _userRepository;
        public UserModel CurrentUser { get; private set; }
        public LoginService(IUserRepository userRepository)
        {
           _userRepository = userRepository;
           
        }
        public async Task<UserModel> LoginAsync(string email, string password)
        {
            await Task.Delay(1000);

            var user = await _userRepository.GetUserAsync(email, password);

            if (user != null)
            {
                CurrentUser = user;
            }

            return user;
        }
    }
}
