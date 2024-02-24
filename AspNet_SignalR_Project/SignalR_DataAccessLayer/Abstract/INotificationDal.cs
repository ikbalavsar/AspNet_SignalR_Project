using SignalR_EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_DataAccessLayer.Abstract
{
    public interface INotificationDal : IGenericDal<Notification>
    {
        int NotificationCountByStatusFalse();

        List<Notification> GetAllNotificationsByFalse();

        void NotificationChangeToTrue(int id);
        void NotificationChangeToFalse(int id);
    }
}
