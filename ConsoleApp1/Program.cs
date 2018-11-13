using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sti = @"C:\Temp\Tal.txt";
            if (!System.IO.File.Exists(sti))
            
                throw new ApplicationException("Filen eksisterer ikke");


            try
            {
                string indhold = System.IO.File.ReadAllText(sti);
                int tal = Convert.ToInt32(indhold);
                tal++;
                string talString = Convert.ToString(tal);
                System.IO.File.WriteAllText(sti, talString);
                
            }
            catch (System.FormatException ex)
            {
                
                throw new ApplicationException("indhold kan ikke konverteres til et Heltal!" + ex);
            }
            catch (Exception)
            {
                throw;
            }

           
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
