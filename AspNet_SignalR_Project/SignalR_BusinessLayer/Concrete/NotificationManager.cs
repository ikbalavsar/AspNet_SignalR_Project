using SignalR_BusinessLayer.Abstract;
using SignalR_DataAccessLayer.Abstract;
using SignalR_EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_BusinessLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        private readonly INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void TAdd(Notification entity)
        {
            _notificationDal.Add(entity);
        }

        public void TDelete(Notification entity)
        {
            _notificationDal.Delete(entity);
        }

        public Notification TGetByID(int id)
        {
            var value = _notificationDal.GetByID(id);
            return(value);
        }

        public List<Notification> TGetListAll()
        {
           var value =  _notificationDal.GetListAll();
            return(value);
        }

        public void TUpdate(Notification entity)
        {
           _notificationDal.Update(entity);
        }
    }
}
