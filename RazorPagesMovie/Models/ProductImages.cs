using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class ProductImages
    {
        [Key]
        public int ID { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Product")]
        public int ProductID { get; set; }
        public string ImagePath { get; set; }

        public Product Product { get; set; }
    }
}
