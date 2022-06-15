using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melem.Models
{
    public class Korisnik
    {
        [Key]
        public int Id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string sifra { get; set; }
        public string emailAdresa { get; set; }
        public string korisnickoIme { get; set; }
        public DateTime datumRodjenja { get; set; }
        public string slikaProfila { get; set; }
        public Spol spol { get; set; }
        public TipKoze tipKoze { get; set; }

        [ForeignKey("Rutina")]
        public int IDRutine { get; set; }
        public TipStrucnjaka tipStrucnjaka { get; set; }
    }

}