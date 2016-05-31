using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Week5Part1.Models
{
    public class Subscription
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]

        public string EmailAddress { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [StringLength(60)]
        public string Name { get; set; }

        [Range(0.0, 100.0, ErrorMessage="Outside the range")]
        public float Amount { get; set; }

    }
}
