using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            System.DateTime d1;
            System.DateTime d2;
            System.DateTime d3;
            d1 = DateTime.Now;
            d2 = new DateTime(2018, 10, 28);
            d3 = new DateTime(2018, 09, 17);


            d1 = d1.AddDays(10);
            Console.WriteLine($"d1 1 = {d1}");

            d1 = d1.AddMinutes(20);
            Console.WriteLine($"d1 2 = {d1}");

            d1 = d1.AddMonths(-1);

            Console.WriteLine($"d1 3  = {d1}");

            TimeSpan t1 = d2.Subtract(d3);
            Console.WriteLine($"t1 = {t1}");

            TimeSpan t2 = new TimeSpan(16, 0, 0);
            Console.WriteLine($"t2 {t2}");

            TimeSpan t3 = new TimeSpan(00, 30, 0);
            Console.WriteLine($"t3 {t3}");

            TimeSpan t4 = t2.Subtract(t3);
            Console.WriteLine($"t4 {t4}");

            TimeSpan t5 = t2.Add(t3);
            Console.WriteLine($"t5 {t5}");



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
