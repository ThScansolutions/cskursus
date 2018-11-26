using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person() { ForNavn = "Tommy", EfterNavn = "Høeg" };
            Elev e = new Elev() { ForNavn = "Jens", EfterNavn = "Sørensen", Klasselokale = "8.2.6" };
            Instruktør i = new Instruktør() { ForNavn = "Michael", EfterNavn = "Cronberg", Nøgleid = "33W" };
                        
            Console.WriteLine(p.FuldtNavn());
            Console.WriteLine(e.FuldtNavn());
            Console.WriteLine(i.FuldtNavn());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }

    class Person
    {
        public string ForNavn { get; set; }

        public string EfterNavn { get; set; }

        public string FuldtNavn()
        {
            return $"FuldtNavn: {this.ForNavn} {this.EfterNavn}";
        }
    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }
    }

    class Instruktør : Person
    {
        public String Nøgleid { get; set; }
    }
}
