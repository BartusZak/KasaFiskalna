using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Produkt
    {
        //zmienne prywatne
        private string nazwa;
        private double cenaJednostkowa;
        private int ilosc;

        //konstuktor domyslny
        public Produkt ()
        {
            this.nazwa = "brak nazwy";
            this.cenaJednostkowa = 0.0;
            this.ilosc = 0;
        }
        // kontsturkto z parametrami
        public Produkt(string Nazwa, double CenaJednostkowa, int Ilosc)
        {
            this.nazwa = Nazwa;
            this.cenaJednostkowa = CenaJednostkowa;
            this.ilosc = Ilosc;
        }
        // metoda
        public static void DodajProdukt()
        {
            Console.WriteLine("Dodajesz Produkt do koszyka:\nPodaj:");
            Console.WriteLine("Nazwa:");
            string nazwa_v = Console.ReadLine();

            Console.WriteLine("Cena Jednostkowa:");
            double cenaJednostkowa_v = double.Parse(Console.ReadLine());

            Console.WriteLine("Ilość:");
            int ilosc_v = int.Parse(Console.ReadLine());

            Koszyk.WyswietlKoszyk();
           // Produkt prod = new Produkt(nazwa_v,cenaJednostkowa_v,ilosc_v);
            

        }
    }
}
