namespace Melem.Models
{
    public class Produkt
    {
        private string naziv { get; set; }
        private string brend { get; set;}
        private double cijena { get; set;}
        private List<Sastojak> sastojci; 
        private double ocjena { get; set;}
        private VrstaPreparata vrstaPreparata; 
        private string lokacija {get;set; }
        private string slikaProdukta { get; set;}
        private string slikaTestera { get; set;}
    }

}
