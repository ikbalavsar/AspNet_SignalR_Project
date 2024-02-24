using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR_Web_UI.Dtos.NotificationDto
{
    public class GetNotificationDto
    {
        public int NotificationId { get; set; }
        public string Type { get; set; }

        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public string Icon { get; set; }
    }
}
