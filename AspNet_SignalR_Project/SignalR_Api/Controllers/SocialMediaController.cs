using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR_BusinessLayer.Abstract;
using SignalR_DtoLayer.SocialMediaDto;
using SignalR_EntityLayer.Entities;

namespace SignalR_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var value = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.TGetListAll()); // önceki controllerdan farklı olarak burada direkt mapleme işlemi yaptık. 
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            _socialMediaService.TAdd(new SocialMedia()
            {
               Icon = createSocialMediaDto.Icon,
               Title = createSocialMediaDto.Title,
               Url = createSocialMediaDto.Url
            });
            return Ok("SocialMedia Added.");
        }

        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {

            var value = _socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(value);
            return Ok("SocialMedia deleted.");
        }

        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            _socialMediaService.TUpdate(new SocialMedia()
            {
               Url = updateSocialMediaDto.Url,
               Title = updateSocialMediaDto.Title,
               Icon = updateSocialMediaDto.Icon,
                SocialMediaID = updateSocialMediaDto.SocialMediaID
            });
            return Ok("SocialMedia updated.");
        }

        [HttpGet("GetSocialMedia")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            return Ok(value);
        }
    }
}
