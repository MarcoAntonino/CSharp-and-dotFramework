namespace Biblioteca
{
    public class Editore
    {
        public string RagioneSociale { get; set; }
        public string Indirizzo { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string SitoWeb { get; set; }

        public Editore() { }

        public Editore (string RagioneSociale, string Indirizzo, string Telefono, string Email, string SitoWeb)
        {
            this.RagioneSociale = RagioneSociale;
            this.Indirizzo = Indirizzo;
            this.Telefono = Telefono;
            this.Email = Email;
            this.SitoWeb = SitoWeb;
        }

        public override string ToString()
        {
            return string.Concat(RagioneSociale, " ",
                                Indirizzo, " ",
                                Telefono, " ",
                                Email, " ",
                                SitoWeb, " ");
        }

    }
}