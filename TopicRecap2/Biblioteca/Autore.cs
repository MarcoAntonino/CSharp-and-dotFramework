using System;

namespace Biblioteca
{
    public class Autore
    {
        public string Nome { get; set; } //tutto quello che è public va scritto in PascalCase
        
        public string Cognome
        {
            get;set;
        }

        public string Iniziali
        {
            get
            {
                return Nome.Substring(0, 1).ToUpper();
            }
        }

        public DateTime DataNascita { get; set; }
        public DateTime? DataMorte { get; set; }//con il punto interrogativo dice che può essere nullable
        public string LuogoNascita { get; set; }
        public string LuogoMorte { get; set; }//non serve nella stringa perchè è già valore null di default

        public bool isAlive
        {
            get
            {
                return DataMorte == null; //è un if, ritorna true
            }
        }

        public override string ToString()
        {
            string isDead = !isAlive ? string.Concat(" - ", DataMorte, ", ", LuogoMorte) : "";

            return string.Concat(Iniziali, ".", Cognome, "(", DataNascita.ToString("MMMM dd, yyyy"), ", ", LuogoNascita, isDead, ")" );// si usa la , al posto del +
        }

        public Autore(string nome, string cognome, DateTime DataNascita, string LuogoNascita) // costruttore per autore vivo
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.DataNascita = DataNascita;
            this.LuogoNascita =LuogoNascita;

            
        }

        public Autore(string nome, string cognome, DateTime DataNascita, string LuogoNascita, DateTime DataMorte, string LuogoMorte) // costruttore per autore vivo
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.DataNascita = DataNascita;
            this.LuogoNascita = LuogoNascita;
            this.DataMorte = DataMorte;
            this.LuogoMorte = LuogoMorte;


        }

        public string NominativoAutore()
        {
            string inizialeNome;            
            string nominativo;
            this.Cognome = Cognome;

            nominativo = "";


            inizialeNome = Nome.Substring(0, 1);
            inizialeNome = inizialeNome.ToUpper();

            

            return nominativo;

        }



    }
}