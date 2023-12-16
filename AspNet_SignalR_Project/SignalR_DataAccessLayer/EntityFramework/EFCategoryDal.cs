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
    public class EFCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EFCategoryDal(SignalRContext context) : base(context)
        {
        }

        public int ActiveCategoryCount()
        {
            using var context = new SignalRContext();
            return context.Categories.Where(x=> x.Status == true).Count();
        }

        public int CategoryCount()
        {
            using var context = new SignalRContext();
            return context.Categories.Count();
        }

        public int PassiveCategoryCount()
        {
            using var context = new SignalRContext();
            return context.Categories.Where(x => x.Status == false).Count();
        }
    }
}
