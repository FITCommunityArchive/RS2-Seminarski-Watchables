using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class UsersRotations
    {
        public int RotationId { get; set; }
        public int UserId { get; set; }
        public DateTime RotationClaimed { get; set; }

        public virtual Rotations Rotation { get; set; }
        public virtual Users User { get; set; }
    }
}
