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
        //Test obsługi zawodów
        static void Main(string[] args)
        {
            //Obiekt obsługujący zawody
            Zawody biegi = new Zawody();

            Zawodnik z1 = new Zawodnik("Janko", "Walski", 23);
            biegi.DodajZawodnika(z1);

            Zawodnik z2 = new Zawodnik("Jerzyk", "Nowak", 19);
            biegi.DodajZawodnika(z2);

            biegi.DodajZawodnika("Maria", "Anonina", 19);

            Console.WriteLine("Lista startujących w biegu:");
            foreach (var zawodnik in biegi.ListaZawodnikow())
            {
                Console.WriteLine(zawodnik);
            }
            
        }
    }
}
