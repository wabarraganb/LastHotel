using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Alten.LastHotel.Aplication.Customer
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CreateCustomerHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
                var customer = this.mapper.Map<Domain.Customer>(request);
                customer.Id = new System.Guid();
                await this.unitOfWork.Customer.AddCustomerAsync(customer);                
                this.unitOfWork.Complete();
                return Unit.Value;
        }
    }
}
