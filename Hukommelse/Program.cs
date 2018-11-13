using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hukommelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Person k1 = new Person();
            Person k2 = new Person();

            k1.navn = "a";
            k2.navn = "b";

            Console.WriteLine($"k1: {k1.navn} k2: {k2.navn}");
            k1 = k2;

            Console.WriteLine($"k1: {k1.navn} k2: {k2.navn}");

            k1.navn = "c";

            Console.WriteLine($"k1: {k1.navn} k2: {k2.navn}");



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }


        }
    }
    class Person
    {
        public string navn;
    }
}
