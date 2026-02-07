using System.ComponentModel.DataAnnotations;

namespace VSM.Domain.AuthModels
{
    public class LoginResponseModel
    {
        [Required]
        public string Token { get; set; }


        public string Role { get; set; }
    }
}
