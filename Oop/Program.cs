using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    class Program
    {
        static void Main(string[] args)
        {

            Person P1 = new Person();
            P1.Fødselsår = 1970;
            P1.Fornavn = "Søren";
            P1.Efternavn = "Jensen";
            Console.WriteLine(P1.FuldtNavn());
            Console.WriteLine(P1.Alder());
            Person P2 = new Person("Tommy", "Høeg", 1969);
            Console.WriteLine(P2.FuldtNavn());
            Console.WriteLine(P2.Alder());




            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

    }
    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;
   

        public string FuldtNavn()
        {
            return $"{this.Fornavn} {this.Efternavn}";
        }

        public int Alder()
        {
            int År = DateTime.Now.Year;
            return År - this.Fødselsår;
        }
        public Person()
        {
            Fornavn = "";
            Efternavn = "";
        }

        public Person(string Fornavn, String Efternavn, int Fødselsår)
        {
            this.Fornavn = Fornavn;
            this.Efternavn = Efternavn;
            this.Fødselsår = Fødselsår;
        }
    }
}

