using VSM.Application.DTOs.Auth;
using VSM.Domain.Models;

namespace VSM.Application.Interfaces
{
    public interface IUserRepository
    {
        User UserAuthenticate(string userName);
        Task<string> RegisterUser(RegisterUserDTO register);
    }
}
