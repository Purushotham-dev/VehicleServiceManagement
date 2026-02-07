using System.ComponentModel.DataAnnotations;

namespace VSM.Domain.Models
{
    public class VehicleDetails
    {
        [Key]
        public Guid VehicleID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string VehicleModel { get; set; }
        [Required]
        public string VehicleNumber { get; set; }

        public string Color { get; set; }

        public Guid UserID { get; set; }
        [Required]
        public User UserDetails { get; set; }
    }
}
