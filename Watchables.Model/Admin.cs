using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model
{
    public class Admin
    {
        public int AdminId { get; set; }
        public Model.Account Account { get; set; }
    }
}
