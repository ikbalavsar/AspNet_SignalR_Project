using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR_BusinessLayer.Abstract;
using SignalR_DtoLayer.AboutDto;
using SignalR_EntityLayer.Entities;

namespace SignalR_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService; //Dependency Injection
        }

        [HttpGet]
        public IActionResult AboutList() 
        {

            var values = _aboutService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto) 
        {
            About about = new About()
            {
                Title = createAboutDto.Title,
                Description = createAboutDto.Description,
                ImageURl = createAboutDto.ImageURl

            };
            _aboutService.TAdd(about);
            return Ok("About is added.");

        
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            _aboutService.TDelete(value);
            return Ok("About is deleted.");
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto) {


            About about = new About()
            {
                Title = updateAboutDto.Title,
                Description = updateAboutDto.Description,
                ImageURl = updateAboutDto.ImageURl,
                AboutID = updateAboutDto.AboutID
            };

            _aboutService.TUpdate(about);
            return Ok("About is updated.");
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
           var value= _aboutService.TGetByID(id);
            return Ok(value);
        }

    }
}
