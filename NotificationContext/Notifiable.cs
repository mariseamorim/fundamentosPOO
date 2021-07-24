using System.Collections.Generic;
using System.Linq;

namespace Balta.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }

        public void AddNotification(Notification notification)
        {   
            Notifications.Add(notification);
        }

        public void AddNotifications(IEnumerable<Notification> notification)
        {   
            Notifications.AddRange(notification);
        }

        public bool IsInvalid => Notifications.Any();
    }
}