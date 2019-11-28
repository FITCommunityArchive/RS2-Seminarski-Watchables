using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model.dgvLists
{
    public class RotationItem
    {
        public int RotationId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public bool ForBirthday { get; set; }
        public int ShowId { get; set; }
        public int MovieId { get; set; }
        public bool Available { get; set; }
        public string Movie { get; set;}
        public string Show { get; set; }
    }
}
