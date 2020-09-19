using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial1.Models
{
    public class Countries
    {
        [Required(ErrorMessage ="You must enter this field {0}")]
        public string alpha3code { get; set; }

        [Required(ErrorMessage = "You must enter this field {0}")]
        public string region { get; set; }

        [Key]
        public string name { get; set; }

        [Required(ErrorMessage = "You must enter this field {0}")]
        public int area { get; set; }

        [Required(ErrorMessage = "You must enter this field {0}")]
        public int callingcodes { get; set; }
      
    }
}