using Investments.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Investiments.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            return NoContent();
        }
    }
}
