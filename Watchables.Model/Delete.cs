using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model
{
    public class Delete
    {
        public int ItemId { get; set; }
        public int UserId { get; set; }
        public BuyItem Item { get; set; }
    }
}
