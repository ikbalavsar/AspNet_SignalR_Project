using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR_BusinessLayer.Abstract;
using SignalR_DtoLayer.NotificationDto;
using SignalR_EntityLayer.Entities;

namespace SignalR_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Notifications : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public Notifications(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
   

        [HttpGet]
        public IActionResult NotificationList()
        {

            var values = _notificationService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateNotification(CreateNotificationDto createNotificationDto)
        {
            Notification Notification = new Notification()
            {
              Type = createNotificationDto.Type,
              Date = DateTime.Now,
              Description = createNotificationDto.Description,
              Status = createNotificationDto.Status

            };
            _notificationService.TAdd(Notification);
            return Ok("Notification is added.");


        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNotification(int id)
        {
            var value = _notificationService.TGetByID(id);
            _notificationService.TDelete(value);
            return Ok("Notification is deleted.");
        }
        [HttpPut]
        public IActionResult UpdateNotification(UpdateNotificationDto updateNotificationDto)
        {


            Notification Notification = new Notification()
            {
                Type = updateNotificationDto.Type,
                Date = DateTime.Now,
                Description = updateNotificationDto.Description,
                Status = updateNotificationDto.Status,
                NotificationId = updateNotificationDto.NotificationId
            };

            _notificationService.TUpdate(Notification);
            return Ok("Notification is updated.");
        }

        [HttpGet("{id}")]
        public IActionResult GetNotification(int id)
        {
            var value = _notificationService.TGetByID(id);
            return Ok(value);
        }

        [HttpGet("NotificationCountByStatusFalse")]
        public IActionResult NotificationCountByStatusFalse()
        {
            return Ok(_notificationService.TNotificationCountByStatusFalse());
        }

        [HttpGet("GetAllNotificationsByFalse")]
        public IActionResult GetAllNotificationsByFalse()
        {
            return Ok(_notificationService.TGetAllNotificationsByFalse());
        }
    }
}
