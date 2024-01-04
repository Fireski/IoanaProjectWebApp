namespace IoanaProjectWebApp.Models
{
    public class Clienti
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime DataComanda { get; set; }
        public string Problema { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}
