using Microsoft.EntityFrameworkCore;
using OrderMgmtSystem.Core.Entity;
using OrderMgmtSystem.Core.Enums;

namespace OrderMgmtSystem.Infrastructure.OMS
{
    public class OMSContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }  

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Order> Orders { get; set; }

        public OMSContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Guid customerId1 = Guid.NewGuid(), customerId2 = Guid.NewGuid(); 
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = customerId1,
                    FirstName = "James",
                    LastName = "Bond",
                    ContactNumber = "041235456",
                    IsDeleted = false,
                    Email = "jamebond@hermajesty.com"
                },
                new Customer
                {
                    Id = customerId2,
                    FirstName = "Monty",
                    LastName = "Python",
                    ContactNumber = "123456789",
                    IsDeleted = false,
                    Email = "monty@hermajesty.com"
                }
            );

            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    Id = Guid.NewGuid(),
                    CustomerId = customerId1,
                    AddressLine1 = "SomePlace",
                    AddressLine2 = "There",
                    City = "Melbourne",
                    State = "Victoria",
                    Country = "AU"
                },
                new Address
                {
                    Id = Guid.NewGuid(),
                    CustomerId = customerId2,
                    AddressLine1 = "Another Place",
                    AddressLine2 = "Here",
                    City = "Melbourne",
                    State = "Victoria",
                    Country = "AU"
                }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = Guid.NewGuid(),
                    CustomerId = customerId1,
                    OrderDate = new DateTime(2022, 10, 20),
                    Description = "New Item",
                    TotalAmount = 500,
                    DepositAmount = 10,
                    IsDelivery = true,
                    status = Status.Pending,
                    OtherNotes = "Something new",
                    IsDeleted = false
                },
                new Order
                {
                    Id = Guid.NewGuid(),
                    CustomerId = customerId2,
                    OrderDate = new DateTime(2022, 11, 10),
                    Description = "Another New Item",
                    TotalAmount = 5000,
                    DepositAmount = 250,
                    IsDelivery = false,
                    status = Status.Draft,
                    OtherNotes = "Something new again",
                    IsDeleted = false
                }
            );
        }
    }
}
