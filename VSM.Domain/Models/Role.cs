using System.ComponentModel.DataAnnotations;

namespace VSM.Domain.Models
{
    public class Role
    {
        [Key]
        public Guid RoleID { get; set; }
        [Required]
        public string RoleName { get; set; }

        public string CreatedBy { get; set; }
    }

}
