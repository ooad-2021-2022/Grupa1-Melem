using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melem.Models
{
    public class Sastojak
    {
        [Key]
        public int ID { get; set; }

        public string naziv { get; set; }
        public Sastojak(){}
}
}