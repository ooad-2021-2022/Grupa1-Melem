using System.Collections.Generic;

namespace Melem.Models
{
    public class Produkt
    {

        public int ID { get; set; }
        public string naziv { get; set; }
        public string brend { get; set;}
        public double cijena { get; set;}
        public int IDSastojkaUProduktu { get; set; }
        
        public double ocjena { get; set;}

        public VrstaPreparata vrstaPreparata; 
        public string lokacija {get;set; }
        public string slikaProdukta { get; set;}
        public string slikaTestera { get; set;}
    }

}
