namespace Melem.Models
{
    public class Korisnik
    {
        private string ime { get; set;}
        private string prezime { get; set;}
        private string sifra { get; set;}
        private string emailAdresa { get; set;}
        private string korisnickoIme {get; set;}
        private datumRodjenja = new DateTime(); 
        private string slikaProfila { get; set;}
        private Spol spol {get; set; }
        private TipKoze tipKoze { get; set; }
        private Rutina rutina {get; set; }
    }

}
