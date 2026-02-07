using System.ComponentModel.DataAnnotations;
using VSM.Domain.Enum;

namespace VSM.Domain.Models
{
    public class ServiceRequestModel
    {
        [Key]
        public Guid ServiceID { get; set; }
        [Required]
        public string MechanicName { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public List<DateTime> UpdatedOn { get; set; }

        public Guid DealerID { get; set; }

        [Required]
        public Dealer Dealer { get; set; }

        public Guid ServiceStatusID { get; set; }

        [Required]
        public ServiceStatus Status { get; set; }

        public Guid VehicleID { get; set; }

        [Required]
        public VehicleDetails VehicleDetails { get; set; }
    }
}
