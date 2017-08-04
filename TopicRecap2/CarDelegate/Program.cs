using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Delegates as event enablers");

            Car c1 = new Car("SlugBug", 10);
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(onCarEngineEvent)); //qui gli passo il metodo che creo sotto. Occhio che è statico infatti non appartiene a nessuna variabile di car
                                                                                  //Inoltre RegisterWithCarEngine si aspetta un'istanza di CarEngineHandler che a sua volta contiene il meotodo che verrà caricato in essa. Ecco perchè troviamo scritto new Car.CarEngineHandler(onCarEngineEvent)

            /*
             * NOTA BENE:
             * c1.RegisterWithCarEngine(onCarEngineEvent);
             * Questa è un'alternativa a quello scritto sopra.
             * C# permette di non istanziare un delegato CarEngineHandler che serve solo per passare il metodo onCarEngineEvent.
             * Siccome il metodo ha la stessa signature, si può passare direttamente al "setter" RegisterWithCarEngine.
             * Questo meccanismo si chiama Method Group Conversion
             */
            c1.RegisterWithCarEngine(onCarEngineEvent2); //aggiungiamo anche il secondo delegate

            Console.WriteLine("***** Speeding Up *****");
                for (int i = 0; i < 6; i++)
                {
                    c1.Accelerate(20);
                }
                Console.ReadLine();

        }

        public static void onCarEngineEvent(string msgForCaller) //ecco qui il metodo. Qui gli dico cosa fare con la stringa che gli ho passato nel metodo accelerate
        {
        Console.WriteLine("\n****Message from Car Object");
        Console.WriteLine("=> {0}", msgForCaller);            
        Console.WriteLine("**********************\n");
        }

        public static void onCarEngineEvent2(string msgForCaller)
        {
            Console.WriteLine("=> {0}", msgForCaller.ToUpper());

        }

    }
}
