using System;
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
        public int NumeroPagine { get; set; }
        public DateTime AnnoPubblicazione { get; set; }
        public Isbn Isbn { get; set; }
        public Editore Editore { get; set; }
        public Autore Autore { get; set; }

        

        public double costoPubblicazione()
        {
            double costoFisso = 7.50; // il loro scope è solo interno al metodo
            double costoStampa = 0.05; // non c'è modo di farle uscire
            return (NumeroPagine*costoStampa)+costoFisso;
        }

         


    }
}
