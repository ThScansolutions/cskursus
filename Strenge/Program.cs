using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string forNavn = "Mikkel";
            string efterNavn = "Cronberg";
            string samletNavn = forNavn +" " + efterNavn;
            Console.WriteLine(samletNavn);
            string stortNavn = samletNavn.ToUpper();
            Console.WriteLine(stortNavn);
            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);
            string cronNavn = samletNavn.Substring(7, 4);
            

            Console.WriteLine(cronNavn);

            Console.WriteLine($"{forNavn}\r\n{efterNavn}");

            System.IO.File.WriteAllText(@"C:\Temp\Test.txt",samletNavn);


            if (System.Diagnostics.Debugger.IsAttached)

            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
