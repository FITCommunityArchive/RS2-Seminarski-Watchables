using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watchables.WebAPI.Services
{
    public interface INotificationService
    {
        public List<Model.Notification> Get();
        public string RemoveNotification(int notificationId, int userId);
    }
}
