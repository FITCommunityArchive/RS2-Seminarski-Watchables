using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class UsersShows
    {
        public int UserId { get; set; }
        public int ShowId { get; set; }

        public virtual Shows Show { get; set; }
        public virtual Users User { get; set; }
    }
}
