using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_EntityLayer.Entities
{
    public class Basket
    {
        public int BasketID { get; set; }

        public int ProductID { get; set; } 
        public decimal ProductPrice { get; set; }
        public int ProductCount { get; set; }
        public decimal TotalPrice { get; set; }
        public Product Product { get; set; }
        public int RestaurantTableID { get; set; }
        public RestaurantTable RestaurantTable { get; set; }
    }
}
