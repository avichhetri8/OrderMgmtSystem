using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMgmtSystem.Core.Entity
{
    public class Customer
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string ContactNmber { get; set; }
        public int IsDelted { get; set; }

        public ICollection<Order>? Orders { get; set; }
    }
}
