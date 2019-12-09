using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }
        public DateTime Created { get; set; }
    }
}
