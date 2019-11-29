using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Watchables.Model.Requests
{
    public class InsertRotationRequest
    {
        [DataType(DataType.Date)]
        [Required]
        public DateTime From { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime To { get; set; }

        [Required]
        [MinLength(4)]
        public string Description { get; set; }

        [Required]
        public bool ForBirthday { get; set; }

        [Required]
        public int ShowId { get; set; }

        [Required]
        public int MovieId { get; set; }

        [Required]
        public bool Available { get; set; }
    }
}
