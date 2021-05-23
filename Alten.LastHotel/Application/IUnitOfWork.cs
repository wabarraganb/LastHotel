using Alten.LastHotel.Aplication.Repository;
using System;

namespace Alten.LastHotel.Aplication
{
    public interface IUnitOfWork: IDisposable
    {
        ICustomerRepository Customer { get; }
        IRoomRepository Room { get; }

        int Complete();
    }
}
