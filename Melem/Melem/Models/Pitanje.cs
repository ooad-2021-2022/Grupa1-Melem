using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melem.Models
{
    public class Pitanje
    {
        [Key]
        public int ID { get; set; }
        public string tekstPitanja { get; set; }
        public Odgovor odgovor { get; set; }

        [ForeignKey("Kviz")]
        public int IDKviza { get; set; }
    }
}