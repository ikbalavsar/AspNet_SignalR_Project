using SignalR_EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_BusinessLayer.Abstract
{
    public interface INotificationService : IGenericService<Notification>
    {
        public int TNotificationCountByStatusFalse();
        public List<Notification> TGetAllNotificationsByFalse();
        public void TNotificationChangeToTrue(int id);

        public void TNotificationChangeToFalse(int id);

	}
}
