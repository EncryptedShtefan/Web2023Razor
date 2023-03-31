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
        public string Fio { get; set; }

        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Дата заезда")]
        [DataType(DataType.Date)]
        public DateTime DateArrive { get; set; }

        [Display(Name = "Дата выезда")]
        [DataType(DataType.Date)]
        public DateTime DateDepart { get; set; }

        [Display(Name = "Номер санатория")]
        public string ApartmentNumber { get; set; }

        [Display(Name = "Оздоровительная программа")]
        public string HealthProgName { get; set; }
    }
}
