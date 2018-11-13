using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indkapsling
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare vare1 = new Vare();
            vare1.Pris = 12;
            vare1.Navn = "Agurk";
            Console.WriteLine($"Slut {vare1.Pris} + {vare1.Navn}");
            Console.WriteLine($"PrismedMoms {vare1.PrisMedMoms()}");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }


        }
    }
    class Vare
    {
        private string navn;
                
        public string Navn
        {
            get
            {
                Console.WriteLine("Her returneres Navn");
                return navn;
            }
            set
            {
                Console.WriteLine("Her sættes Navn ");
                navn = value;
            }
        }

        private double pris;

        public double Pris
        {
            get
            {
                Console.WriteLine("Her returneres Pris");
                return pris;
            }
            set
            {
                Console.WriteLine("Her sættes Pris ");
                pris = value;

            }
        }

        public double PrisMedMoms()
        {
            return this.pris * 1.25;

        }

        public Vare():this (0, "Default")
        {

        }

        public Vare(int pris, string navn)
        {
            this.Pris = pris;
            this.Navn = navn;
        }
    }
}
