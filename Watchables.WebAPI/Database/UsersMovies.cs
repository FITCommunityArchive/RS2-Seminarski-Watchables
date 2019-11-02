using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class UsersMovies
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }

        public virtual Movies Movie { get; set; }
        public virtual Users User { get; set; }
    }
}
