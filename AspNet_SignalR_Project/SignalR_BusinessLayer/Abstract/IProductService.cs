using SignalR_EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();

        int TProductCount();
        int TProductCountByCategoryNameByHamburger();
        int TProductCountByCategoryNameByDrink();
        decimal TProductPriceAvg();

        string TProductNameByMaxPrice();
        string TProductNameByMinPrice();
        decimal TProductAvgPriceByBurger();
    }
}
