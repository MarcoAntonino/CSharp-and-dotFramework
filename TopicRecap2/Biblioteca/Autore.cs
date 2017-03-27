using System;

namespace Biblioteca
{
    public class Autore
    {
        public string Nome { get; set; } //tutto quello che è public va scritto in PascalCase
        public string InizialeNome {
            get
            {
                return Nome.Substring(0, 1).ToUpper();
            }
        }
        public string cognome
        {
            get;set;
        }
        public DateTime DataNascita { get; set; }
        public DateTime? DataMorte { get; set; }//con il punto interrogativo dice che può essere nullable
        public string LuogoNascita { get; set; }
        public string LuogoMorte { get; set; }//non serve nella strainga perchè è già valore null di default

        public bool isAlive
        {
            get
            {
                return DataMorte == null; //è un if, ritorna true
            }
        }

        public override string ToString()
        {
            string isDead = !isAlive ? string.Concat(" - ✝ ", DataMorte, ", ", LuogoMorte) : "";

            return string.Concat(InizialeNome, ".", cognome, "(✰ ", DataNascita, ", ", LuogoNascita, isDead, ")" );// si usa la , al posto del +
        }





    }
}