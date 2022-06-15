using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melem.Models
{
    public class Odgovor
    {
        public int vrijednostOdgovora { get; set; }

        [Key]
        public int ID { get; set; }

        [ForeignKey("Pitanje")]
        public int IDPitanja { get; set; }
    }
}