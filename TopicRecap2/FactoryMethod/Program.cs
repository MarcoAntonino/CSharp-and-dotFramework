using FactoryMethod.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TurkeySandwich myFistSandwhich = new TurkeySandwich();
            Console.WriteLine(myFistSandwhich.ToString());
            Console.ReadLine();
        }
    }
}
