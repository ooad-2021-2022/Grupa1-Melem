using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melem.Models
{
    public class SastojakIzProdukta
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Produkt")]
        public int IDProdukta { get; set; }

        [ForeignKey("Sastojak")]
        public int IDSastojka { get; set; }
        public SastojakIzProdukta(){}

}
}