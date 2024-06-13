using System.ComponentModel.DataAnnotations;

namespace Sample_CQRS_API.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CustomerNumber { get; set; }

        [StringLength(20)]
        [Required]
        public string FullName { get; set; } = string.Empty;

        [StringLength(50)]
        public string Address { get; set; } = string.Empty;

        [StringLength(15)]
        [Required]
        public string Mobile { get; set; } = string.Empty;
    }
}
