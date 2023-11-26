using AutoMapper;
using SignalR_DtoLayer.BookingDto;
using SignalR_EntityLayer.Entities;

namespace SignalR_Api.Mapping
{
    public class BookingMapping : Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking,ResultBookingDto>().ReverseMap();
            CreateMap<Booking,CreateBookingDto>().ReverseMap();
            CreateMap<Booking,UpdateBookingDto>().ReverseMap();
            CreateMap<Booking,GetBookingDto>().ReverseMap();
            
        }
    }
}
