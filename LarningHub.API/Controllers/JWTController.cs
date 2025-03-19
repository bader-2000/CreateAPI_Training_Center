using LarningHub.Core.Data;
using LarningHub.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LarningHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JWTController : ControllerBase
    {
        private IJWTService _jWTService;

        public JWTController(IJWTService jWTService)
        {
            _jWTService = jWTService;
        }

        [HttpPost]
        public IActionResult Auth([FromBody]Login login) 
        {
            var tokin = _jWTService.AuthLogin(login);
            if (login == null) 
            {
                return Unauthorized();  

            } else {

                return Ok(tokin);
            }
        }


    }
}
