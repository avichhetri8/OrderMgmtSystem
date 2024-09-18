using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderMgmtSystem.Core.Entity
{
    public class Address
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        public required string AddressLine1 { get; set; } 
        public string? AddressLine2 { get; set; }
        public required string State { get; set; }
        public required string Country { get; set; }
    }
}
