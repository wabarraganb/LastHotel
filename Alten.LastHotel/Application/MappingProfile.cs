using Alten.LastHotel.Aplication.Customer;
using Alten.LastHotel.Aplication.Customer.Dto;
using Alten.LastHotel.Aplication.Room;
using AutoMapper;

namespace Alten.LastHotel.Aplication
{
    public class MappingProfile : Profile
    {
        public MappingProfile() => ConfigureCustomerMapping();
       

        protected void ConfigureCustomerMapping()
        {
            CreateMap<Domain.Customer, CreateCustomerCommand>()
              .ForMember(d => d.BirthDate, opt => opt.MapFrom(src => src.BirthDate))
              .ForMember(d => d.Name, opt => opt.MapFrom(src => src.Name))
              .ForMember(d => d.LastName, opt => opt.MapFrom(src => src.LastName))
              .ReverseMap();

            CreateMap<Domain.Customer, CustumerDto>().ReverseMap();
            CreateMap<Domain.Room, CreateRoomCommand>()
                .ForMember(d => d.RoomNumber, opt => opt.MapFrom(src => src.Number)).ReverseMap();
        }

    }
}
