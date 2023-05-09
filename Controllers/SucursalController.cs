using Jwt.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SucursalController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            var listSucursal = SucursalConstants.Sucursales;
            return Ok(listSucursal);
        }

    }
}
