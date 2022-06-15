using System;

namespace Melem.Models
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string ime { get; set;}
        public string prezime { get; set;}
        public string sifra { get; set;}
        public string emailAdresa { get; set;}
        public string korisnickoIme {get; set;}
        public DateTime datumRodjenja { get; set; }
        public string slikaProfila { get; set;}
        public Spol spol {get; set; }
        public TipKoze tipKoze { get; set; }
        public int IDRutine {get; set; }
        public TipStrucnjaka tipStrucnjaka { get; set; }
    }

}
