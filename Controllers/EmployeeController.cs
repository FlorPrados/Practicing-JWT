using Jwt.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        [HttpGet]
        [Authorize(Roles = ("Admin"))]     //Especificamos el rol que queremos que acceda a este mètodo
        public IActionResult Get()
        {
            var listEmployee = EmployeeConstants.Employees;
            return Ok(listEmployee);
        }
    }
}
