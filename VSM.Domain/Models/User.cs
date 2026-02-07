using System.ComponentModel.DataAnnotations;
using VSM.Domain.AuthModels;

namespace VSM.Domain.Models
{
    public class User
    {
        [Key]
        public Guid UserID { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public Guid RoleID { get; set; }
        public Role Role { get; set; }

        // Foreign key to Login
        public Guid LoginID { get; set; }
        public LoginRequestModel Login { get; set; }

    }
}
