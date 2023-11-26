using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR_BusinessLayer.Abstract;
using SignalR_DtoLayer.BookingDto;
using SignalR_EntityLayer.Entities;

namespace SignalR_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail = createBookingDto.Mail,
                Date = createBookingDto.Date,
                Name = createBookingDto.Name,
                PersonCount = createBookingDto.PersonCount,
                Phone = createBookingDto.Phone
            };

            _bookingService.TAdd(booking);
            return Ok("Booking added.");
        }

        [HttpDelete]
        public IActionResult DeleteBooking(int id) {
        
            var value = _bookingService.TGetByID(id);
            _bookingService.TDelete(value);
            return Ok("Booking deleted.");
        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            var booking = new Booking()
            {
                Mail = updateBookingDto.Mail,
                Date = updateBookingDto.Date,
                Name = updateBookingDto.Name,
                PersonCount = updateBookingDto.PersonCount,
                Phone = updateBookingDto.Phone,
                BookingID = updateBookingDto.BookingID
            };

            _bookingService.TUpdate(booking);
            return Ok("Booking updated");
        }

        [HttpGet("GetBooking")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            return Ok(value);
        }
    }
}
