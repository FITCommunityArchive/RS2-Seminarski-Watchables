using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class Admins
    {
        public int AdminId { get; set; }

        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
    }
}
