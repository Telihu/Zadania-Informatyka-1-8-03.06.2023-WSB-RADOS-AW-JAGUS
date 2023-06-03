using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Infa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Wpisz swoją pierwszą liczbę :");
            
            double liczba1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine(" Wpisz swoją drugą liczbę :");
            
            double liczba2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine(" Wpisz swoją trzecią liczbę :");

            double liczba3 = Convert.ToDouble(Console.ReadLine());

            double srednia = (liczba1 + liczba2 + liczba3) / 3 ;
            Console.WriteLine(" Twoja Średnia To :", srednia);

            Console.ReadKey();
            

        }
    }
}
