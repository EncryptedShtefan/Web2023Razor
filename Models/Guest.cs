using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web2023Razor.Models
{
    public class Guest
    {
        [Key]
        public int IdG { get; set; }
        public string Fio { get; set; }

        [DataType(DataType.Date)]
        public DateTime birthDate { get; set; }

    }
}
