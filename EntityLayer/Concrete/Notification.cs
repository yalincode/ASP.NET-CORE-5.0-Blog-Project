using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string NotificationType { get; set; }
        public string NotficationTypeSymbol { get; set; }
        public string NotificationDetails { get; set; }
        public bool NotificationStatus { get; set; }
        public DateTime NotificationDate { get; set; }
        public string NotificationColor { get; set; }
    }
}
