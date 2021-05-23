using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alten.LastHotel.Aplication.Repository
{
    public interface ICustomerRepository : IRepository<Domain.Customer>
    {
        Task AddCustomerAsync(Domain.Customer customer);
        Task<IEnumerable<Domain.Customer>> GetAllCustomersAsync();
    }
}
