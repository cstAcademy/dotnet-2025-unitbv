using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tickify.Core.Dtos.Requests.Auth;
using Tickify.Core.Services;

namespace Tickify.Api.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersController : ControllerBase
    {
        private UsersService usersService { get; set; }

        public UsersController(UsersService usersService)
        {
            this.usersService = usersService;
        }

        [HttpPost("/register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterRequest payload)
        {
            await usersService.RegisterAsync(payload);
            return Ok("Registration successful");
        }

        [HttpPost("/login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginRequest payload)
        {
            var jwtToken = await usersService.LoginAsync(payload);

            return Ok(new { token = jwtToken });
        }
    }
}
