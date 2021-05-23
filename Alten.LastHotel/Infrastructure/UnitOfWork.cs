using Alten.LastHotel.Aplication;
using Alten.LastHotel.Aplication.Repository;
using Alten.LastHotel.Persistence.Repositories;

namespace Alten.LastHotel.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LastHotelContext lastHotelContext;

        public UnitOfWork(LastHotelContext lastHotelContext)
        {
            this.lastHotelContext = lastHotelContext;
            Customer = new CustomerRepository(this.lastHotelContext);
            Room = new RoomRepository(this.lastHotelContext);
        }
        public ICustomerRepository Customer { get; private set; }

        public IRoomRepository Room  { get; private set; }

    public int Complete()
        {
          return  this.lastHotelContext.SaveChanges();
        }

        public void Dispose()
        {
            this.lastHotelContext.Dispose();
        }
    }
}
