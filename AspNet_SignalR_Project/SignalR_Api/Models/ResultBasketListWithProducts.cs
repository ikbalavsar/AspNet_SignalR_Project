using SignalR_EntityLayer.Entities;

namespace SignalR_Api.Models
{
    public class ResultBasketListWithProducts
    {
        public int BasketID { get; set; }

        public int ProductID { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductCount { get; set; }
        public decimal TotalPrice { get; set; }
        public int RestaurantTableID { get; set; }
        public string ProductName { get; set; }
    }
}
