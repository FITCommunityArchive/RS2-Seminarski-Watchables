using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class OrderProducts
    {
        public int OrderProductsId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
    }
}
