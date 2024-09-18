using OrderMgmtSystem.Core.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OrderMgmtSystem.Core.Entity
{
    public class Order
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        public string Description { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal DepositAmount { get; set; }
        public bool IsDelivery { get; set; }
        public string? OtherNotes { get; set; }
        public bool IsDeleted { get; set; }

        public Customer Customer { get; set; }

        public Status status { get; set; }  



    }
}
