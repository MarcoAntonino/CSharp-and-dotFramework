using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{

    class Libro
    {
        public string Titolo { get; set; } 
        public string Genere { get; set; }
        public string Isbn { get; set; }
        public int NumeroPagine { get; set; }
        public DateTime AnnoPubblicazione { get; set; }
        public Editore Editore { get; set; }
        public ArrayList Autori { get; set; }        

        public double costoPubblicazione()
        {
            double costoFisso = 7.50; // il loro scope è solo interno al metodo
            double costoStampa = 0.05; // non c'è modo di farle uscire
            return (NumeroPagine*costoStampa)+costoFisso;
        }

        public Libro() { }

        public Libro(string titolo, string genere, string isbn, int numeroPagine, DateTime annoPubblicazione, Editore editore, ArrayList autore)
        {
            Titolo = titolo;
            Genere = genere;
            Isbn = isbn;
            NumeroPagine = numeroPagine;
            AnnoPubblicazione = annoPubblicazione;
            Editore = editore;
            Autori = autori;
        }

        public override string ToString()
        {
            return string.Concat("Titolo: ",Titolo, "\n",
                                 "Autore: ",Autore.nom, ".", Autore.Cognome, "\n",
                                 "Genere: ", Genere, "\n",
                                 "Isbn: ", Isbn, "\n",
                                 "Pagine: ", NumeroPagine, "\n",
                                 "AnnoPubblicazione: ", AnnoPubblicazione, "\n",
                                 "Editore: ", Editore.RagioneSociale, "\n",
                                 "Costo: ", costoPubblicazione());
        }
    }
}
