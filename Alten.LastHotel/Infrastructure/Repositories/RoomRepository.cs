using Alten.LastHotel.Aplication.Repository;
using Alten.LastHotel.Domain;
using System.Threading.Tasks;

namespace Alten.LastHotel.Persistence.Repositories
{
    public class RoomRepository : Repository<Room>, IRoomRepository
    {
        public RoomRepository(LastHotelContext lastHotelContext) : base(lastHotelContext)
        {

        }
        public async Task AddRoomAsync(Room room)
        {
            await LastHotelContext.Rooms.AddAsync(room);
        }

        public LastHotelContext LastHotelContext
        {
            get { return Context as LastHotelContext; }
        }
    }
}
