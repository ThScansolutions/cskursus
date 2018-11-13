using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgenskaberAutomatisk
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { Efternavn = "Høeg", Fornavn = "Tommy" };
            Console.WriteLine(p1.FuldtNavn());
            p1.Efternavn = "Sørensen";
            p1.Fornavn = "Mikkel";
            Console.WriteLine(p1.FuldtNavn());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
