using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string ProductName { get; set; }


        [Required]
        public string ProductDesc { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public string ManufactureDate { get; set; }

    }
}
