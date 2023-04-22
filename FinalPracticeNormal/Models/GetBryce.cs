using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalPracticeNormal.Models
{
    public class GetBryce
    {
        [Key]
        [Required]
        public int ApplicationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Major { get; set; }
        public bool TommyJohn { get; set; }
    }
}
