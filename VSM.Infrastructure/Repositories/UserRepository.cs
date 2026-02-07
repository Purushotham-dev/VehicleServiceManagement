using VSM.Application.DTOs.Auth;
using VSM.Application.Interfaces;
using VSM.Domain.Models;
using VSM.Infrastructure.Data;


namespace VSM.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDBContext _dbContext;
        public UserRepository(AppDBContext DbContext)
        {
            _dbContext = DbContext;
        }

        public async Task<string> RegisterUser(RegisterUserDTO register)
        {
            var user = UserAuthenticate(register.UserName);

            if (user != null)
            {
                return "User already exists";
            }

            var role = _dbContext.Roles.FirstOrDefault(x => x.RoleName == "USER");

            user = new User
            {
                UserName = register.UserName,
                Email = register.Email,
                PhoneNumber = register.Phone,
                Role = role,
            };
            var item = await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            if (item != null)
            {
                return "User registered successfully";
            }
            return "User registration Failed";
        }


        public User? UserAuthenticate(string userName)
        {
            return _dbContext.Users.FirstOrDefault(x => x.UserName == userName);
        }


    }
}
