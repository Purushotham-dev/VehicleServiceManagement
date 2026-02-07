using VSM.Application.DTOs.Auth;
using VSM.Application.Interfaces;

namespace VSM.Application.Services
{
    public class AuthenticateService : IAuthenticateUser
    {
        private readonly IUserRepository _userRepository;
        public AuthenticateService(IUserRepository UserRepository)
        {
            _userRepository = UserRepository;
        }


        public async Task<string> RegisterUserData(RegisterUserDTO RegisterUserDTO)
        {
            return await _userRepository.RegisterUser(RegisterUserDTO);
        }


        public string AuthentiateUser(string username, string password)
        {
            var user = _userRepository.UserAuthenticate(username);

            if (user == null) { return null; }


            return null;

        }
    }
}
