using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Watchables.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [MinLength(4)]
        public string Name { get; set; }

        [Range(1, 150)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
