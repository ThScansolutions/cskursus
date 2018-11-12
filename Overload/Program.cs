using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            int res1 = Beregn(1, 2);
            int res2 = Beregn(1, 2,3);
            int res3 = Beregn(1, 2, 4 ,5);
            Console.WriteLine($"{res1} + {res2} + {res3}");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static int Beregn(int a, int b)
        {
            return a + b;
        }

        static int Beregn(int a, int b, int c)
        {
            return Beregn(a,b) + c;
        }

        static int Beregn(int a, int b, int c , int d)
        {
            return Beregn(a,b,c)+ d;
        }
    }
}
