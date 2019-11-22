using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model
{
    public class Rotation
    {
        public int RotationId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Description { get; set; }
        public bool ForBirthday { get; set; }
        public int ShowId { get; set; }
        public int MovieId { get; set; }
        public bool Available { get; set; }
    }
}
