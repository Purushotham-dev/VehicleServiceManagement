using System.ComponentModel.DataAnnotations;

namespace VSM.Application.DTOs.Auth
{
    public class LoginRequestDTO
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
