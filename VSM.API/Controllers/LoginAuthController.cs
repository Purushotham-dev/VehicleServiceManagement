using Microsoft.AspNetCore.Mvc;
using VSM.Application.DTOs.Auth;
using VSM.Domain.AuthModels;

namespace VSM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginAuthController : ControllerBase
    {
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO authdata)
        {
            if (authdata == null)
            {
                return BadRequest("Login Details should not be empty");
            }

            var request = new LoginRequestModel
            {

                UserName = authdata.UserName,
                Password = authdata.Password
            };


            return null;

        }
    }
}
