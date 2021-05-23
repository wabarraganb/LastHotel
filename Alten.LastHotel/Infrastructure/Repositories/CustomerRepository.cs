using Alten.LastHotel.Aplication.Repository;
using Alten.LastHotel.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Alten.LastHotel.Persistence
{

    public class CustomerRepository : Repository<Domain.Customer>, ICustomerRepository
    {
        public CustomerRepository(LastHotelContext lastHotelContext) : base(lastHotelContext)
        {

        }
        public async Task AddCustomerAsync(Domain.Customer customer)
        {
           await LastHotelContext.AddAsync(customer);
        }

        public async Task<IEnumerable<Domain.Customer>> GetAllCustomersAsync()
        {
            return await LastHotelContext.Customers.ToListAsync();
        }

        public LastHotelContext LastHotelContext
        {
            get { return Context as LastHotelContext; }
        }

    }
}
