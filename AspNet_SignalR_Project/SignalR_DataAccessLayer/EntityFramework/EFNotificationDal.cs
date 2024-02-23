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
    public class EFNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        public EFNotificationDal(SignalRContext context) : base(context)
        {

        }
    }
}
