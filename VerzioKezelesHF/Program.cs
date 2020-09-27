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
            int bekerLenght;
            Console.Write("Mennyi szamot akar megadni? ");
            bekerLenght = int.Parse(Console.ReadLine());
            double[] szamok = new double[bekerLenght];
            
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write("Adjon meg egy szamot a(z) {0}. szamot: ",i+1);
                szamok[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("A megadott szamok atlaga: "+szamok.Sum()/szamok.Length);
            Console.ReadKey();
        }
    }
}
