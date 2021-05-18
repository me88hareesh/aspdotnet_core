using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [Required,MaxLength(20,ErrorMessage ="should not be more than 20 character long")]
        public string Name { get; set; }

        [Required, MaxLength(10),MinLength(9)]
        public string Contact { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
