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

        [Display(Name = "ФИО")]
        [Required]
        public string Fio { get; set; }

        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Дата заезда")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateArrive { get; set; }

        [Display(Name = "Дата выезда")]
        [DataType(DataType.Date)]
        public DateTime DateDepart { get; set; }

        
        [Display(Name = "Номер санатория")]
        [Required]
        public string ApartmentNumber { get; set; }

        
        [Display(Name = "Оздоровительная программа")]
        public string HealthProgName { get; set; }
    }
}
