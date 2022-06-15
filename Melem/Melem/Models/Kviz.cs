using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Melem.Models
{
    public class Kviz
    {
        [ForeignKey("Korisnik")]
        public int korisnickiID { get; set; }

        [Key]
        public int ID { get; set; }
    }
}