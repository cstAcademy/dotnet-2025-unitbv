using Tickify.Core.Dtos.Requests.Auth;
using Tickify.Database.Entities;
using Tickify.Database.Repositories;

namespace Tickify.Core.Services
{
    public class UsersService
    {
        public AuthService authService { get; set; }
        public UsersRepository usersRepository { get; set; }

        public UsersService(
            AuthService authService,
            UsersRepository usersRepository)
        {
            this.authService = authService;
            this.usersRepository = usersRepository;
        }

        public async Task RegisterAsync(RegisterRequest registerData)
        {
            if (registerData == null)
            {
                return;
            }

            var salt = authService.GenerateSalt();
            var hashedPassword = authService.HashPassword(registerData.Password, salt);

            var user = new User();
            user.FirstName = registerData.FirstName;
            user.LastName = registerData.LastName;
            user.Email = registerData.Email;
            user.PhoneNumber = registerData.PhoneNumber;
            user.Password = hashedPassword;
            user.PasswordSalt = Convert.ToBase64String(salt);
            user.CreatedAt = DateTime.UtcNow;

            await usersRepository.AddAsync(user);
        }

        public async Task<string> LoginAsync(LoginRequest payload)
        {
            var user = await usersRepository.GetByEmailAsync(payload.Email);

            if (authService.HashPassword(payload.Password, Convert.FromBase64String(user.PasswordSalt)) == user.Password)
            {
                var role = GetRole(user);

                return authService.GetToken(user, role);
            }
            else
            {
                throw new UnauthorizedAccessException("Invalid email or password.");
            }
        }

        private string GetRole(User user)
        {
            if (user.IsAdmin)
            {
                return "Admin";
            }
            else
            {
                return "User";
            }
        }
    }
}
