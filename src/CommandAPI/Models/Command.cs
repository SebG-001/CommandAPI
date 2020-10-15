using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CommandAPI.Models
{
    // This is a class that represents the data to be accessed/stored
    // from/in a database or elsewhere
    public class Command
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }
        
        [Required]
        public string Platform { get; set; }
        
        [Required]
        public string CommandLine { get; set; }
    }
}
