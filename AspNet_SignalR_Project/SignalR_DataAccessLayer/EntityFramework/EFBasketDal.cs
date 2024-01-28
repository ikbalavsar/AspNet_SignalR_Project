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
    public class EFBasketDal : GenericRepository<Basket>, IBasketDal
    {
        public EFBasketDal(SignalRContext context) : base(context)
        {

        }

        public List<Basket> GetBasketByTableNumber(int id)
        {
            using var context = new SignalRContext();
            var values = context.Baskets.Where(x=>x.RestaurantTableID == id).ToList();
            return values; 
        }
    }
}
