using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktioner
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Lægsammen(200, 2);
            Console.WriteLine(res);

            double res1 = Double(2, 2);
            Console.WriteLine(res1);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }


        static int Lægsammen(int a, int b)
        {
            return a * b;
        }


        static double Double(double a, double b)
        {
            return a * b * System.Math.PI;
        }
    }
   
}
