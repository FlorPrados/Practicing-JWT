using Jwt.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Authorize]   // puede ser tanto a nivel de mètodo o a nivel de controlador. Depende donde lo ubique
        public IActionResult Get()
        {
            var listProduct = ProductConstants.products;
            return Ok(listProduct);
        }
    }
}
