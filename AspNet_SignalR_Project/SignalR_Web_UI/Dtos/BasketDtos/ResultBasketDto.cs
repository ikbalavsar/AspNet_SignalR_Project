namespace SignalR_Web_UI.Dtos.BasketDtos
{
    public class ResultBasketDto
    {
        public int BasketID { get; set; }

        public int ProductID { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductCount { get; set; }
        public decimal TotalPrice { get; set; }
        public int RestaurantTableID { get; set; }
    }
}
