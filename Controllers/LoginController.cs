using Jwt.Constants;
using Jwt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;
        public LoginController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost]
        public IActionResult Login(LoginUser loginUser)
        {
            var user = Authenticate(loginUser);

            if(user != null)
            {
                // Creacion del token
                var token = Generate(user);

                return Ok(token);
            }
            return NotFound("User not found");
           
        }

        private UserModel Authenticate(LoginUser loginUser)
        {
            var user = UserConstants.Users.FirstOrDefault(user => user.Username.ToLower() == loginUser.Username.ToLower()
                                                          && user.Password == loginUser.Password);

            if (user != null)
            {
                return user;
            }
            return null;
        }

        private string Generate(UserModel user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Creacion de los claims (reclamaciones)
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Username),
                new Claim(ClaimTypes.Email, user.EmailAdress),
                new Claim(ClaimTypes.Role, user.Rol),
                new Claim(ClaimTypes.Name, user.Fullname),
                new Claim("addClaim", "probando"),

            };

            // Creacion del token
            var token = new JwtSecurityToken(
                _config["Jwt: Issuer"],
                _config["Jwt: Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(10),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
