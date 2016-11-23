using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Aplikacja 
    {
        private char klawisz;

        public void WczytajKlawisz()
        {
            Console.WriteLine("Dzień dobry!");
            Console.WriteLine("Co chcesz zrobić? Naciśnij odpowieni klawisz.");
            Console.WriteLine("Legenda:");
            Console.WriteLine("P - dodaj produkt do koszyka");
            Console.WriteLine("K - skopiuj ostatnio wprowadzony produkt");
            Console.WriteLine("Z - pokaż zawartośc koszyka");
            Console.WriteLine("S - pokaż sume do zapłaty");
            Console.WriteLine("X - skasuj produkt z listy (muisz znać wcześniej numer na liście)");
            Console.WriteLine("W - wydrukuj paragon");
            Console.WriteLine("N - dodaj nowy koszyk");
            Console.WriteLine("E - zakończ działanie programu");
            klawisz = char.Parse(Console.ReadLine());
        }

        public void WykonajDzialanie()
        {
            while (klawisz != 'E')
            {
                switch (klawisz)
                {
                    case 'P': Produkt.DodajProdukt(); break;
                    case 'K': break;
                    case 'Z': break;
                    case 'S': break;
                    case 'X': break;
                    case 'W': break;
                    case 'N': break;
                    case 'E': Environment.Exit(0); break;
                    default: Console.Clear(); WczytajKlawisz(); break;
                }
            }
          }
        }
           
        
    }

  

