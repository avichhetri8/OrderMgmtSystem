using OrderMgmtSystem.Core.Entity;
using OrderMgmtSystem.Infrastructure.OMS;

namespace OrderMgmtSystem.Server.GraphQL
{
    public class Query
    {
        [UseFiltering]
        public IQueryable<Customer> GetCustomers([Service] OMSContext context)
        {
            context.Database.EnsureCreated();
            return context.Customers;
        }
    }
}