using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejlhåndtering
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Run();
                
            }
            catch (Exception ex)
            {
                PrøvIgen();
                Console.WriteLine("Der skal indtastes et tal" + ex.Message);
                


            }

           
        }
        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int res = tal1 + tal2;
            Console.WriteLine("resultatet er " + res);
        }

        static void PrøvIgen()
        {
            int count = 0;
            int antal = 3;

            while (count < antal)

            {
                try
                {
                    Run();
                    break;

                }
                catch (Exception)
                {
                    Console.WriteLine("Der skal indtastes et tal");
                    Console.WriteLine("Prøv igen");
                    count++;
                }
              
             
            }
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }


    }
}
