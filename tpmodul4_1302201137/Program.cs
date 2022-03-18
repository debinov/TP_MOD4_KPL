// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Collections.Generic;

//Debi Ratnasari Novianti 1302201137

namespace tpmod4_1302201137

{
    internal class Program
    {
        static void Main(string[] args)
        {

            HaloGeneric<string> Halo = new HaloGeneric<string>();
            String x = "Debi Ratnasari Novianti";
            Halo.SapaUser(x);

        }
    }
    public class HaloGeneric<T>
    {
        public void SapaUser(T x)
        {
            Console.WriteLine("HALOO!!!! " + x );

            DataGeneric<String> data = new DataGeneric<string>("1302201137");
            data.PrintData();
        }
    }

    public class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("Data Yang Tersimpan Adalah NIM  : " + this.data);

        }
    }
}

