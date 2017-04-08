using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dNascA1 = new DateTime(1986, 05, 04);
            Autore a1 = new Autore("Marco", "Antonino", dNascA1, "Torino");
            System.Console.WriteLine(a1);

            DateTime dNascA2 = new DateTime(1921, 12, 12);
            DateTime dMortA2= new DateTime(1961, 4, 23);
            Autore a2 = new Autore("Franco", "Pizarro", dNascA2, "Torino", dMortA2, "Genova");
            System.Console.WriteLine(a2);

            Editore e1 = new Editore("Mondadori", "Via Roma 14, Torino", "0118134567", "info@mondadori.it", "www.mondadori.it");
            System.Console.WriteLine(e1);




            System.Console.ReadKey();

        }
    }
}
