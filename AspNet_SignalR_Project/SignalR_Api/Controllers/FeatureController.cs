using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR_BusinessLayer.Abstract;
using SignalR_DtoLayer.FeatureDto;
using SignalR_EntityLayer.Entities;

namespace SignalR_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult FeatureList()
        {
            var value = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetListAll()); // önceki controllerdan farklı olarak burada direkt mapleme işlemi yaptık. 
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            _featureService.TAdd(new Feature()
            {
               Description1 = createFeatureDto.Description1,
               Description2 = createFeatureDto.Description2,    
               Description3 = createFeatureDto.Description3,
               Title1 = createFeatureDto.Title1,
               Title2 = createFeatureDto.Title2,
               Title3 = createFeatureDto.Title3
            });
            return Ok("Feature Added.");
        }

        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {

            var value = _featureService.TGetByID(id);
            _featureService.TDelete(value);
            return Ok("Feature deleted.");
        }

        [HttpPut]
        public IActionResult UpdateCatgeory(UpdateFeatureDto updateFeatureDto)
        {
            _featureService.TUpdate(new Feature()
            {
                Title1 = updateFeatureDto.Title1,
                Title2 = updateFeatureDto.Title2,   
                Title3 = updateFeatureDto.Title3,
                Description3 = updateFeatureDto.Description3,
                Description1 = updateFeatureDto.Description1,
                Description2 = updateFeatureDto.Description2,
                FeatureID = updateFeatureDto.FeatureID
            });
            return Ok("Feature updated.");
        }

        [HttpGet("GetFeature")]
        public IActionResult GetFeature(int id)
        {
            var value = _featureService.TGetByID(id);
            return Ok(value);
        }

    }
}
