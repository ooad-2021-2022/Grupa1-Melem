namespace Melem.Models
{
    public class Pitanje
    {
        public string tekstPitanja { get;set;}
        public Odgovor odgovor { get; set;}

        public int ID { get; set; }
        public int IDKviza { get; set; }
    }
}
