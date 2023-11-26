using AutoMapper;
using SignalR_DtoLayer.ContactDto;
using SignalR_EntityLayer.Entities;

namespace SignalR_Api.Mapping
{
    public class ContactMapping: Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact,ResultContactDto>().ReverseMap();
            CreateMap<Contact,CreateContactDto>().ReverseMap();
            CreateMap<Contact,UpdateContactDto>().ReverseMap();
            CreateMap<Contact,GetContactDto>().ReverseMap();

        }
    }
}
