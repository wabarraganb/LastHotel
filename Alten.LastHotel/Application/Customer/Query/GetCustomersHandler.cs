using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Alten.LastHotel.Aplication.Customer
{
    public class GetCustomersHandler : IRequestHandler<GetCustomersQuery, IEnumerable<Dto.CustumerDto>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetCustomersHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<Dto.CustumerDto>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            var result =  await unitOfWork.Customer.GetAllCustomersAsync();
            return this.mapper.Map<IEnumerable<Dto.CustumerDto>>(result);
        }
    }
}
