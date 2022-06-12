namespace Melem.Models
{
    public class StrucnjakIzPrakse
    {
        public int Id { get; set;}
        private string ime { get; set;}
        private string prezime { get; set;}
        private string sifra { get; set;}
        private string emailAdresa { get; set;}
        private string slikaProfila { get; set;}
        private TipStrucnjaka tipStrucnjaka { get; set; }
    }
}
