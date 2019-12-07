using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model
{
    public class Buy
    {
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public BuyItem Item { get; set; }
    }
}


public enum BuyItem
{
    Movie,
    Show,
    Subscription, 
    Rotation
}

