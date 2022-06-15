using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melem.Models
{
    public class Rutina
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Korisnik")]
        public int IDKorisnika { get; set; }

        public string vrsta { get; set; }
        public bool zavrsnea { get; set; }
        public Rutina(){}
}
}