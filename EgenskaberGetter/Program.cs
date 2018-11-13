using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgenskaberGetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t1 = new Trekant(12.3, 12);
            Console.WriteLine(t1.Areal);
            Trekant t2 = Trekant.Trekant_10_10();            
            Console.WriteLine(t2.Areal);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
