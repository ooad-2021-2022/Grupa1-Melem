using System;

namespace Melem.Models
{
    public class Korisnik
    {
        private int Id { get; set; }
        private string ime { get; set;}
        private string prezime { get; set;}
        private string sifra { get; set;}
        private string emailAdresa { get; set;}
        private string korisnickoIme {get; set;}
        private DateTime datumRodjenja { get; set; }
        private string slikaProfila { get; set;}
        private Spol spol {get; set; }
        private TipKoze tipKoze { get; set; }
        private Rutina rutina {get; set; }
        private TipStrucnjaka tipStrucnjaka { get; set; }
    }

}
