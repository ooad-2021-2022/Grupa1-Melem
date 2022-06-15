using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melem.Models
{
    public class Kviz
    {
       private int korisnickiID { get;set;}
        private List<Pitanje> pitanja; 
    }
}
