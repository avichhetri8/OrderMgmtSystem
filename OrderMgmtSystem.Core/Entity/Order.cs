using OrderMgmtSystem.Core.Enums;

namespace OrderMgmtSystem.Core.Entity
{
    public class Order
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        public string Description { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal DepositAmount { get; set; }
        public int IsDelivery { get; set; }
        public int Status { get; set; }
        public string? OtherNotes { get; set; }
        public int IsDeleted { get; set; }

        public required Customer Customer { get; set; }

        public Status status { get; set; }  



    }
}
