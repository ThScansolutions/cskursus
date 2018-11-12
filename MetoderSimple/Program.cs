using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res);

            double res1 = BeregnAreal(5);
            Console.WriteLine(res1);

            string res2 = Udskriv();
            Console.WriteLine(res2);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(double a)
        {
            return a * a * Math.PI;
        }

        static string Udskriv()
        {
            return "Dette er en Test";
        }

    }

}
