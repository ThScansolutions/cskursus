using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndkapslingTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            t.Skriv();
            t.Ryst();
            t.Skriv();
            t.Værdi = 7;
            t.Skriv();
            t.Ryst();
            t.Skriv();
            t = new Terning(6);
            t.Skriv();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    class Terning
    {
        private static System.Random rnd = new Random();
        private int værdi;

        public int Værdi
        {
            get
            {
                Console.WriteLine("Get værdi " + this.værdi);
                return this.værdi;
            }
            set
            {
                if (value < 0 || value > 6)
                value = 1;
                Console.WriteLine("Set værdi" + value);
                this.værdi = value;
            }
        }
        

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }

        public Terning(int værdi)
        {
            this.værdi = værdi;
        }

        public Terning()
        {
            this.Ryst();
        }
    }

}
