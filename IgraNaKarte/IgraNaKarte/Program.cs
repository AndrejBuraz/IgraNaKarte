using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraNaKarte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj, zbroj = 0;
            do
            {
                unos: Console.WriteLine("Unesi vrijednost karte (1-13): ");
                broj = Convert.ToInt32(Console.ReadLine());
                if(broj > 0 && broj < 14)
                {
                    zbroj += broj;
                }
                else
                {
                    Console.WriteLine("Pogresan unos!");
                    goto unos;
                }
            } while(zbroj < 31);
            if(zbroj == 31)
            {
                Console.WriteLine("Pobijedili ste!");
            }
            else
            {
                Console.WriteLine("Izgubili ste!");
            }
            Console.ReadKey();
        }
    }
}
