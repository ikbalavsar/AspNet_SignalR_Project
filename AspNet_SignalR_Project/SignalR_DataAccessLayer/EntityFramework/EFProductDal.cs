using Microsoft.EntityFrameworkCore;
using SignalR_DataAccessLayer.Abstract;
using SignalR_DataAccessLayer.Concrete;
using SignalR_DataAccessLayer.Repositories;
using SignalR_EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_DataAccessLayer.EntityFramework
{
    public class EFProductDal : GenericRepository<Product>, IProductDal
    {
        public EFProductDal(SignalRContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            var context = new SignalRContext();
            var values = context.Products.Include(x=>x.Category).ToList();  
            return values;
        }

        public int ProductCount()
        {
           using var context = new SignalRContext();
            var values = context.Products.Count();
            return values;
        }

        public int ProductCountByCategoryNameByDrink()
        {
            using var context = new SignalRContext();
            return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.Name == "İçecek")).Select(z => z.CategoryID).FirstOrDefault()).Count();
        }

        public int ProductCountByCategoryNameByHamburger()
        {
            using var context = new SignalRContext();
            return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.Name == "İçecek")).Select(z => z.CategoryID).FirstOrDefault()).Count();
        }

        public string ProductNameByMaxPrice()
        {
            using var context = new SignalRContext();
            return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public string ProductNameByMinPrice()
        {
            using var context = new SignalRContext();
            return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public decimal ProductPriceAvg()
        {
            using var context = new SignalRContext();
            return context.Products.Average(x => x.Price);
        }

        public decimal ProductAvgPriceByBurger()
        {
            using var context = new SignalRContext();
            return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.Name == "Burger").Select(z => z.CategoryID).FirstOrDefault())).Average(w => w.Price);
        }
    }
}
