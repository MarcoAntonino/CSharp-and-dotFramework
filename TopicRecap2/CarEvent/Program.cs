using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Carolina", 10, 100);

            c1.AboutToBlow += CarIsAlmostDoomed;
            c1.AboutToBlow += CarAboutToBlow;

            c1.Exploded += CarExploded;

            Console.WriteLine("***** Speeding Up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            Console.ReadLine();
        }

        private static void CarExploded(object sender, CarEventArgs e)
        {
            Console.WriteLine("{0} says: {1}", sender, e.msg);
        }

        private static void CarAboutToBlow(object sender, CarEventArgs e)
        {
            Console.WriteLine("{0} says: {1}", sender, e.msg);
        }

        private static void CarIsAlmostDoomed(object sender, CarEventArgs e)
        {
            Console.WriteLine("{0} says: {1}", sender, e.msg);
        }
    }
}
