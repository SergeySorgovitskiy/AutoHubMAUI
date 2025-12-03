using AutoHub.MVVM.Models;
using AutoHub.Services.Repositories.UserRepository;

namespace AutoHub.Services.RegisterService
{
    public class RegisterService(IUserRepository userRepository) : IRegisterService
    {
        public async Task<bool> RegisterAsync(UserModel newUser)
        {
            var existingUser = await userRepository.GetUserByEmailAsync(newUser.Email);

            if (existingUser != null)
            {
                throw new InvalidOperationException("The user with this email already exists.");
            }

            await userRepository.AddUserAsync(newUser);

            return true;
        }
    }
}
