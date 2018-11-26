using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdvidetRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom random = new UdvidetRandom();
            Console.WriteLine(random.NextBool());
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class UdvidetRandom : System.Random
    {
        public bool NextBool()
        {
            return this.Next(1, 1002) < 501;   
        }
    }

}
