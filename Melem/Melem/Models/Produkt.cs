using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melem.Models
{
    public class Produkt
    {
        [Key]
        public int ID { get; set; }

        public string naziv { get; set; }
        public string brend { get; set; }
        public double cijena { get; set; }
        public double ocjena { get; set; }

        public VrstaPreparata vrstaPreparata;
        public string lokacija { get; set; }
        public string slikaProdukta { get; set; }
        public string slikaTestera { get; set; }
    }

}
