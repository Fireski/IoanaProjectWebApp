using System;

namespace IoanaProjectWebApp.Models
{
    public class Angajati
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime DataAngajarii { get; set; }
        public string Departament { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; } 
    }
}
