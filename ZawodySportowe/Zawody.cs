using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZawodySportowe
{
    public class Zawody
    {
        //private Zawodnik[] zawodnicy = new Zawodnik[10];
        //Zamiast tablicy możemy użyć kolekcji
        private List<Zawodnik> zawodnicy = new List<Zawodnik>();

        //Zawodnicy
        //Zawodnik: Imie, Nazwisko, wiek, wynik
        public void DodajZawodnika(Zawodnik nowyZawodnik)
        {
            zawodnicy.Add(nowyZawodnik);
        }

        public void DodajZawodnika(string imie, string nazwisko, int wiek, decimal wynik=0)
        {
            Zawodnik nowyZawodnik = new Zawodnik(imie, nazwisko, wiek);
            if (wynik != 0)
            {
                nowyZawodnik.ZapiszWynik(wynik);
            }
            zawodnicy.Add(nowyZawodnik);
        }

        public List<string> ListaZawodnikow()
        {
            List<string> strZawodnicy = new List<string>();
            foreach (Zawodnik z in zawodnicy)
            {
                strZawodnicy.Add($"{z.Imie} {z.Nazwisko}");
            }
            return strZawodnicy;
        }
    }

    
}
