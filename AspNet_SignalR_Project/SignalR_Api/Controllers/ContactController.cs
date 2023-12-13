using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR_BusinessLayer.Abstract;
using SignalR_DtoLayer.ContactDto;
using SignalR_EntityLayer.Entities;

namespace SignalR_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll()); // önceki controllerdan farklı olarak burada direkt mapleme işlemi yaptık. 
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd(new Contact()
            {
               Phone = createContactDto.Phone,
               Mail = createContactDto.Mail,
               FooterDescription = createContactDto.FooterDescription,
               Location = createContactDto.Location
            });
            return Ok("Contact Added.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {

            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return Ok("Contact deleted.");
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            _contactService.TUpdate(new Contact()
            {
                Phone = updateContactDto.Phone,
                Mail = updateContactDto.Mail,
                FooterDescription = updateContactDto.FooterDescription,
                Location = updateContactDto.Location,
                ContactID = updateContactDto.ContactID
            });
            return Ok("Contact updated.");
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetByID(id);
            return Ok(value);
        }
    }
}
