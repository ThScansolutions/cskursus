using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;

            heltal++;

           // Console.WriteLine(heltal);

            heltal--;

           // Console.WriteLine(heltal);

            heltal += 20;

            Console.WriteLine($"Heltal = {heltal}");

            double kommatal = 12.5;

            kommatal++;

            //Console.WriteLine(kommatal);

            kommatal--;

            //Console.WriteLine(kommatal);

            kommatal *= 2;

            Console.WriteLine($"kommatal = {kommatal}");


            DebugWait();

        }
        //This will show Console when using F5 
        private static void DebugWait()
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
