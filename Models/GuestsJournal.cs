using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web2023Razor.Models
{
    public class GuestsJournal
    {
        [Key]
        public int IdZ { get; set; }
        public int IdG { get; set; }
        public int IdP { get; set; }
        public int IdN { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime DateArrive { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime DateDepart { get; set; }
        
    }
}
