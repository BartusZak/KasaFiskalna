using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Koszyk
    {
        private List<Produkt> zakupy;

        public static void DodajDoListy(string nazwa, double cenaJednostkowa, int ilosc)
        {
            Console.WriteLine("Dodaje {0} do koszyka!", nazwa);
            List<Produkt> zakupy = new List<Produkt>();
            zakupy.Add(new Produkt(nazwa, cenaJednostkowa, ilosc));

           
        }

        public static void WyswietlKoszyk()
        {
            Console.WriteLine("Pokazuje koszyk...");
              // zakupy.ForEach(Console.WriteLine);
            // nie wiem jak wyswietlic
        }

    }
}
