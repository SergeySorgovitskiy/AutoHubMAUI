using AutoHub.MVVM.Models;
using AutoHub.Services.Repositories.UserRepository;

namespace AutoHub.Services.RegisterService
{
    public class RegisterService: IRegisterService
    {
        private readonly IUserRepository _userRepository;
        public RegisterService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> RegisterAsync(UserModel newUser)
        {
            await Task.Delay(1000);

            var existingUser = await _userRepository.GetUserByEmailAsync(newUser.Email);

            if (existingUser != null)
            {
                throw new InvalidOperationException("The user with this email already exists.");
            }

            await _userRepository.AddUserAsync(newUser);

            return true;
        }
    }
}
