using System.ComponentModel.DataAnnotations;
using VSM.Domain.Models;

namespace VSM.Domain.AuthModels
{
    public class LoginRequestModel
    {
        [Key]
        public Guid LoginID { get; set; }
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public User User { get; set; }

    }
}
