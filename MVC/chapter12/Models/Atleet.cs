using System;
using System.ComponentModel.DataAnnotations;

namespace chapter12.Models
{
    public class Atleet
    { 
        [Key]
        public int ID { get; set; }
        public string Naam { get; set; }

        [DataType(DataType.Date)]
        public DateTime Geboortedatum { get; set; }

        public string Nationaliteit { get; set; }

    }

}
    
   