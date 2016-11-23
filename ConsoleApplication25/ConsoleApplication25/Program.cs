using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplikacja nowa = new Aplikacja();
            nowa.WczytajKlawisz();
            nowa.WykonajDzialanie();

            
        }
    }
}
