using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {



            Terning t = new Terning();

            t.Skriv();

            t.Ryst();

            t.Skriv();



            LudoTerning l = new LudoTerning();

            l.Skriv();

           //Console.WriteLine($"Er jeg en Globus {l.ErGlobus()} eller er jeg en Stjerne {l.ErStjerne()} ");
           

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

}
