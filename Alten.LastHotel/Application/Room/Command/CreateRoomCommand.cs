using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alten.LastHotel.Aplication.Room
{
    public class CreateRoomCommand : IRequest
    {
        public int RoomNumber { get; set; }
    }
}
