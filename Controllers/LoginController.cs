using Jwt.Constants;
using Jwt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        [HttpPost]
        public IActionResult Login(LoginUser loginUser)
        {
            var user = Authenticate(loginUser);

            if(user != null)
            {
                return Ok("User login");
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

    }
}
