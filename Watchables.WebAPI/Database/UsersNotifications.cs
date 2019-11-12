using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class UsersNotifications
    {
        public int UsersNotificationsId { get; set; }
        public int UserId { get; set; }
        public int NotificationId { get; set; }

        public virtual Notifications Notification { get; set; }
        public virtual Users User { get; set; }
    }
}
