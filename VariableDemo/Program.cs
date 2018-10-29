using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int length = 10;
            double tal = 11111.00;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(i + " {0}", tal);
                Console.WriteLine($"Doublemin = {System.Double.MaxValue}");
                Console.WriteLine($"Doublemax = {System.Double.MinValue}");

            }
                                
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


