using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model.ObservableLists
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public string Movie { get; set; }
        public decimal Total { get; set; }
        public int Seats { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Cinema { get; set; }
        public string Day { get; set; }
    }
}
