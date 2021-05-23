using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alten.LastHotel.Aplication.Repository
{
    public interface IRoomRepository : IRepository<Domain.Room>
    {
        Task AddRoomAsync(Domain.Room room);
    }
}
