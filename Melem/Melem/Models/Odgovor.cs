using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melem.Models{ 
    public class Odgovor
{
    [Key]
    public int ID { get; set; }
    public int vrijednostOdgovora { get; set; }
    [ForeignKey("Pitanje")]
    public int IDPitanja { get; set; }
}
}