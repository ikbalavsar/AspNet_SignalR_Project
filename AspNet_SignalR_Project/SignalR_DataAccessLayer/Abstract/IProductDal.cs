﻿using SignalR_EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories();
        public int ProductCount();
        int ProductCountByCategoryNameByHamburger();
        int ProductCountByCategoryNameByDrink();

        decimal ProductPriceAvg();

        string ProductNameByMaxPrice();
        string ProductNameByMinPrice();

        decimal ProductAvgPriceByBurger();
    }
}
