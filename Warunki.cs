using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz liczbę którą chcesz porównać: ");
            string num01 = Console.ReadLine();
            Console.WriteLine("Wpisz liczbę do porównania: ");
            string num02 = Console.ReadLine();
            int numerek1 = 0, numerek2 = 0;
            //Program działa tylko do 1 pomyłki jak nie to weźmie 0 jako liczby podane przez użytkownika
            try
            {
                numerek1 = Convert.ToInt32(num01);
                numerek2 = Convert.ToInt32(num02);
            }
            catch
            {
                Console.WriteLine("Podaj ponownie dwie liczby");
                Console.WriteLine("Wpisz liczbę którą chcesz porównać: ");
                num01 = Console.ReadLine();
                Console.WriteLine("Wpisz liczbę do porównania: ");
                num02 = Console.ReadLine();
                numerek1 = Convert.ToInt32(num01);
                numerek2 = Convert.ToInt32(num02);
            }
            if (numerek1 > numerek2)
            {
                Console.WriteLine("Liczba " + num01 + " jest większa od " + num02);
            }
            else
            {
                Console.WriteLine("Liczba " + num02 + " jest większa od " + num01);
            }
            Console.ReadKey();
        }
    }
}
