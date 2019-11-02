using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class CinemaProducts
    {
        public int CinemaId { get; set; }
        public int ProductId { get; set; }

        public virtual Cinemas Cinema { get; set; }
        public virtual Products Product { get; set; }
    }
}
