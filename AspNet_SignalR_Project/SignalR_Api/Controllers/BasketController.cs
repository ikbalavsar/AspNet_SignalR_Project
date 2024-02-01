using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR_Api.Models;
using SignalR_BusinessLayer.Abstract;
using SignalR_DataAccessLayer.Concrete;
using SignalR_DtoLayer.BasketDto;
using SignalR_EntityLayer.Entities;

namespace SignalR_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet]
        public IActionResult GetBasketByTableNumber(int id)
        {
            var values = _basketService.TGetBasketByTableNumber(id);
            return Ok(values);
        }

        [HttpGet("BasketListByMenuTableWithProductName")]
        public IActionResult BasketListByMenuTableWithProductName(int id)
        {
            using var context = new SignalRContext();
            var values = context.Baskets.Include(x => x.Product).Where(y => y.RestaurantTableID == id).Select(z => new ResultBasketListWithProducts
            {
                BasketID = z.BasketID,
                ProductCount = z.ProductCount,
                RestaurantTableID = z.RestaurantTableID,
                ProductPrice = z.ProductPrice,
                ProductID = z.ProductID,
                TotalPrice = z.TotalPrice,
                ProductName = z.Product.ProductName
            }).ToList();

            return Ok(values);

        }

        [HttpPost]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {
            using var context = new SignalRContext();
            _basketService.TAdd(new Basket()
            {
                ProductCount = 1,
                RestaurantTableID = 1,
                ProductPrice = context.Products.Where(x => x.ProductID == createBasketDto.ProductID).Select(y => y.Price).FirstOrDefault(),
                TotalPrice = 0,
                ProductID = createBasketDto.ProductID
            });
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBasket(int id)
        {
            var value = _basketService.TGetByID(id);
            _basketService.TDelete(value);
            return Ok("Product from basket is deleted.");
        }

    }
}
