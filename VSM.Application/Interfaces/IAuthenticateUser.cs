using VSM.Application.DTOs.Auth;

namespace VSM.Application.Interfaces
{
    public interface IAuthenticateUser
    {
        string AuthentiateUser(string username, string password);
        Task<string> RegisterUserData(RegisterUserDTO RegisterUserDTO);
    }
}
