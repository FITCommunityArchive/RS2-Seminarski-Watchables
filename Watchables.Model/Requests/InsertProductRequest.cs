using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Watchables.Model.Requests
{
    public class InsertProductRequest
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Range(1, 150)]
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Price { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for cinemaId")]
        public int CinemaId { get; set; }
    }
}

