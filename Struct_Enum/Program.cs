using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            FilTyper ft = FilTyper.csv;
            Console.WriteLine((int)ft);

            Person P = new Person();
            P.id = 1;
            P.navn = "Mikkel";
            Console.WriteLine($"Person id: {P.id} Navn: {P.navn}");
            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

}
