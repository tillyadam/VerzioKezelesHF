using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] szamok = new double[10];

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write("Adjon meg egy szamot a(z) {0}. szamot: ",i+1);
                szamok[i] = double.Parse(Console.ReadLine());
            }
        }
    }
}
