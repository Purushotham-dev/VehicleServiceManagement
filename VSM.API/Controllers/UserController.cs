using Microsoft.AspNetCore.Mvc;
using VSM.Application.DTOs.Auth;
using VSM.Application.Interfaces;

namespace VSM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAuthenticateUser _authenticateUser;
        public UserController(IAuthenticateUser AuthenticateUser)
        {
            _authenticateUser = AuthenticateUser;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDTO Register)
        {
            var registeruser = await _authenticateUser.RegisterUserData(Register);
            return Ok(registeruser);
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginRequestDTO authdata)
        {
            if (authdata == null)
            {
                var token = _authenticateUser.AuthentiateUser(authdata.UserName, authdata.Password);
                return Ok(token);
            }

            return null;
        }



    }
}
