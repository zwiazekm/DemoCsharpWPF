using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZawodySportowe;

namespace Sport1
{
    class Program
    {
        static void Main(string[] args)
        {
            Zawodnik z1 = new Zawodnik("Janko", "Walski", 23);

            //PRzykład inicjalizacji obiektu
            Zawodnik z2 = new Zawodnik("Jerzyk", "Nowak", 19);

            z1.Imie = "Antek";
            string imieZ2 = z2.Imie;

            z1.ZapiszWynik(2.45M);
            z2.ZapiszWynik(3.2M);

            Console.WriteLine(z1.InfoZawodnik());
            Console.WriteLine(z2.InfoZawodnik());
            

        }
    }
}
