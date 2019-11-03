using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Watchables.Model.Requests
{
    public class InsertCinemaRequest
    {
        [Required]
        public Cinema Cinema { get; set; }

        [Required]
        public List<Hall> Halls { get; set; }

        [Required]
        public List<Product> Products { get; set; }
       


    }
}
