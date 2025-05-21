using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickify.Infrastructure.Base
{
    [ApiController]
    public class BaseController : Controller
    {
        public BaseController()
        {
        }

        protected int GetUserId()
        {
            var rawToken = HttpContext.Request.Headers["Authorization"].FirstOrDefault();
            var token = rawToken.Substring("Bearer ".Length).Trim();
            var parsedToken = new JwtSecurityTokenHandler().ReadJwtToken(token);

            var userIdRaw = parsedToken.Claims.First(c => c.Type == "userId").Value;
            var userId = Int32.Parse(userIdRaw);

            return userId;
        }
    }
}
