using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class Rotations
    {
        public Rotations()
        {
            UsersRotations = new HashSet<UsersRotations>();
        }

        public int RotationId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Description { get; set; }
        public bool ForBirthday { get; set; }
        public int ShowId { get; set; }
        public int MovieId { get; set; }

        public virtual Movies Movie { get; set; }
        public virtual Shows Show { get; set; }
        public virtual ICollection<UsersRotations> UsersRotations { get; set; }
    }
}
