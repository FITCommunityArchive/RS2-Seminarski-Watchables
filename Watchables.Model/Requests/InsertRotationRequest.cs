using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model.Requests
{
    public class InsertRotationRequest
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Description { get; set; }
        public bool ForBirthday { get; set; }
        public int ShowId { get; set; }
        public int MovieId { get; set; }
        public bool Available { get; set; }
    }
}
