using System.Collections.Generic;

namespace Melem.Models
{
    public class Rutina
    {
        public string vrsta { get; set;}
        public bool zavrsnea { get; set;}
        public int ID { get; set;}
        public int IDKorisnika { get; set; }
        public int IDRutinaKorisnika { get; set; }

    }
}
