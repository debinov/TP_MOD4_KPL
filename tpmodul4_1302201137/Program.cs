// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Collections.Generic;


// Debi Ratnasari Novianti 1302201137

namespace tpmodul4_1302201137
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric<string> halo = new HaloGeneric<string>();
            Console.WriteLine("NAMA PRAKTIKAN");

            
            String x = "Debi Ratnasari Novianti";
            halo.SapaUser(x);

        }
    }

    public class HaloGeneric<T>
    {
        public void SapaUser(T x)
        {
            Console.WriteLine("HALOOO!!! " + x );
        }

    }

}
