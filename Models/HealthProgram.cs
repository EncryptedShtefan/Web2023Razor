using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web2023Razor.Models
{
    public class HealthProgram
    {
        [Key]
        public int IdP { get; set; }

        [Display(Name = "Оздоровительная программа")]
        [Required]
        public string HealthProgName { get; set; }

    }
}
