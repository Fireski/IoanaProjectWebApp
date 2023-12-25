using System;

namespace IoanaProjectWebApp.Models
{
    public class Monitorizare
    {
        public int ID { get; set; }
        public string Angajati { get; set; }
        public string Services { get; set; }
        public string Client { get; set; }
        public DateTime Date { get; set; } 
        public string Status { get; set; }
    }
}
