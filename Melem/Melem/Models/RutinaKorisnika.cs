using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melem.Models
{
    public class RutinaKorisnika
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Rutina")]
        public int IDRutine { get; set; }

        [ForeignKey("Produkt")]
        public int IDProdukta { get; set; }
    }
}