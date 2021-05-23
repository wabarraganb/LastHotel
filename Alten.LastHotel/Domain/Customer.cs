using System;

namespace Alten.LastHotel.Domain
{
    public class Customer : Entity
    {        
        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}
