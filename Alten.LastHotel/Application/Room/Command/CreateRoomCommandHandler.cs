using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alten.LastHotel.Aplication.Room.Command
{
    public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CreateRoomCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
        {
            var room = this.mapper.Map<Domain.Room>(request);
            room.Id = new Guid();
            await this.unitOfWork.Room.AddRoomAsync(room);
            this.unitOfWork.Complete();
            return Unit.Value;
        }
    }
}
