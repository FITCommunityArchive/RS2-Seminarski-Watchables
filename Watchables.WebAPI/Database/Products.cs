using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class Products
    {
        public Products()
        {
            OrderProducts = new HashSet<OrderProducts>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CinemaId { get; set; }

        public virtual Cinemas Cinema { get; set; }
        public virtual ICollection<OrderProducts> OrderProducts { get; set; }
    }
}
