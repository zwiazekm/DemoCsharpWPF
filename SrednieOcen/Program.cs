using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrednieOcen
{
    /* 1. Metoda wyswietlająca menu:
     *      - dodaj ocene
     *      - wyswietl oceny
     *      - srednia
     *      - koniec
     * 
     * 
     */
    class Program
    {
        //Zmienna na poziomie klasy. 
        static string[] oceny = new string[10];

        static void Main(string[] args)
        {
            WykonajMenu();
            InfoKoniec();
        }

        //Wyświetla pozycje menu
        static void Menu()
        {
            Console.Clear();
            string trescMenu = "Wybor opcji:\n" +
                               "1. Dodaj ocenę\n" +
                               "2. Wyświetl oceny\n" +
                               "3. Pokaż średnią\n" +
                               "0. Koniec\n";
            Console.WriteLine(trescMenu);
        }

        //Informacje koncowe
        static void InfoKoniec()
        {
            Console.Write("Koniec programu. Wciśnij ENTER");
            Console.ReadLine();
        }

        //Metoda pobierająca dane od użytkownika na konsoli
        static string PobierzDane(string komunikat)
        {
            Console.Write($"{komunikat}:");
            return Console.ReadLine();
        }

        //Metoda wykonująca wybór menu.Aplikacja
        static void WykonajMenu()
        {
            bool czyKoniec = false;
            do
            {
                Menu();
                //int wybor = int.Parse(PobierzDane("Podaj komendę"));
                int wybor;
                if(!int.TryParse(PobierzDane("Podaj komendę"), out wybor))
                {
                    wybor = -1;
                }

                switch (wybor)
                {
                    case 1:
                        DodawanieOceny();
                        break;
                    case 2:
                        WyswietlanieOcen();
                        break;
                    case 3:
                        SredniaOcen();
                        break;
                    case 0:
                        Console.WriteLine("Wybrałeś koniec");
                        czyKoniec = true;
                        break;
                    default:
                        Console.WriteLine("Błędny wybór");
                        break;
                }
                PobierzDane("Wciśnij ENTER");
            } while (!czyKoniec);
        }

        private static void WyswietlanieOcen()
        {
            Console.Write("Lista ocen: ");
            string listaOcen = "";
            foreach (var ocena in oceny)
            {
                if (ocena == null)
                {
                    continue;
                }
                listaOcen += $"{ocena}, ";
            }
            if (listaOcen.Length==0)
            {
                listaOcen = "Brak ocen!!!";
            }
            else
            {
                listaOcen = listaOcen.Substring(0, listaOcen.Length - 2);
            }
            Console.WriteLine(listaOcen);
        }

        static void DodawanieOceny()
        {
            Console.WriteLine("Dodawanie ocen");
            string ocena = PobierzDane("Podaj ocenę");
            //znajdź pierwszy pusty element tablicy i dodaj ocenę
            //jeżeli nie ma pustych elementów powiększ tablicę o 10
            for (int i = 0; i < oceny.Length; i++)
            {
                if ((i == oceny.Length-1) && (oceny[i] !=null))
                {
                    int newSize = oceny.Length + 10;
                    Array.Resize(ref oceny, newSize);
                    continue;
                }
                if (oceny[i] ==null)
                {
                    oceny[i] = ocena;
                    break;
                }
            }
        }

        static void SredniaOcen()
        {
            decimal sumaOcen = 0, liczbaOcen = 0;
            foreach (string ocena in oceny)
            {
                //Jeżeli komórka jest pusta nie bierzemy do średniej.
                if(ocena == null)
                {
                    continue;
                }
                liczbaOcen++;
                //Szukamy czy jest plus lub minus
                string tmpOcena=ocena;
                decimal plusMinus = 0;
                int gdziePlusMinus = ocena.IndexOf('+');
                if (gdziePlusMinus != -1)
                {
                    plusMinus = 0.5M;
                    if (gdziePlusMinus==0)
                    {
                        tmpOcena = ocena.Substring(1, 1);
                    }
                    else
                    {
                        tmpOcena = ocena.Substring(0, 1);
                    }
                }
                gdziePlusMinus = ocena.IndexOf('-');
                if (gdziePlusMinus != -1)
                {
                    plusMinus = -0.25M;
                    if (gdziePlusMinus == 0)
                    {
                        tmpOcena = ocena.Substring(1, 1);
                    }
                    else
                    {
                        tmpOcena = ocena.Substring(0, 1);
                    }
                }
                sumaOcen += decimal.Parse(tmpOcena) + plusMinus;
            }
            decimal wynik = sumaOcen / liczbaOcen;
            Console.WriteLine($"Średnia ocen wynosi: {wynik}");
        }
    }
}
