using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alten.LastHotel.Aplication.Customer
{
    public class CreateCustomerCommand : IRequest
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}
