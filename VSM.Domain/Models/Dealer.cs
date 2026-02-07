using System.ComponentModel.DataAnnotations;

namespace VSM.Domain.Models
{
    public class Dealer
    {
        [Key]
        public Guid DealerID { get; set; }

        [Required]
        public string DealerName { get; set; }

        public bool IsActive { get; set; }


    }
}
