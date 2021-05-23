using Alten.LastHotel.Aplication.Customer.Dto;
using MediatR;
using System.Collections.Generic;


namespace Alten.LastHotel.Aplication.Customer
{
    public class GetCustomersQuery : IRequest<IEnumerable<CustumerDto>> { }
}
