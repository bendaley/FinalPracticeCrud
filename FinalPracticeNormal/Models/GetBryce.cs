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
        [Required]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="I need to know your name")]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Phone { get; set; }
        //public string Major { get; set; }
        [Required]
        public bool TommyJohn { get; set; }


        // build foreign key relationship
        public int MajorId { get; set; }
        public Major Major {get; set; }
    }
}
