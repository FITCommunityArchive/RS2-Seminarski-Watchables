using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class Notifications
    {
        public Notifications()
        {
            UsersNotifications = new HashSet<UsersNotifications>();
        }

        public int NotificationId { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }

        public virtual ICollection<UsersNotifications> UsersNotifications { get; set; }
    }
}
