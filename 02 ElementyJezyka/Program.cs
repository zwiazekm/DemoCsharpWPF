using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmienne
{
    class Program
    {
        static void Main(string[] args)//Metoda startowa
        {
            //KonstrukcjeJezyka();
            //decimal l1 = konwertDoDecimal(PobierzDane("Podaj pierwszą liczbe:"));
            //decimal l2 = konwertDoDecimal(PobierzDane("Podaj drugą liczbę"));
            //decimal l3 = konwertDoDecimal(PobierzDane("Podaj trzecia liczbę"));
            //Test();
            //decimal w = Obliczenia.Dodawanie(l1, l2);
            //Console.WriteLine($"Wynik dodawania: {w}");
            //w = Obliczenia.Dodawanie(l1, l2, l3);
            //w = Obliczenia.Dodawanie("34", "654");


            //Tablice
            string[] teksty=new string[3];
            //Array ar;
            int[,] liczby = new int[2,3];
            decimal[,,] liczbyDec = new decimal[1,2,4];
            byte[] bajtki = { 34, 21, 12, 41 }; //zainicjuje tablice 4'ro elementową

            teksty[0] = "pierwszy";
            teksty[2] = "trzeci";
            liczby[0, 2] = 23;
            
            Console.WriteLine(teksty[0]);

            //pętla for
            Console.WriteLine("Wynik pętli for:");
            for (int i = 0; i < teksty.Length; i++)
            {
                if (teksty[i] == null)
                {
                    continue;
                }
                string wartosc = teksty[i];
                //teksty[i] = "Nowa wartosc";
                Console.WriteLine($"Pozycja {i} = {wartosc}");
            }

            //pętla while
            Console.WriteLine("Wynik pętli while:");
            int indexElementu = 0;
            while (indexElementu < teksty.Length)
            {
                if (indexElementu==2)
                {
                    break;
                }

                string wartosc = teksty[indexElementu];
                Console.WriteLine($"Pozycja {indexElementu} = {wartosc}");
                indexElementu++;
            }

            //pętla do
            Console.WriteLine("Wynik pętli do:");
            indexElementu = 0;
            do
            {
                string wartosc = teksty[indexElementu];
                Console.WriteLine($"Pozycja {indexElementu} = {wartosc}");
                indexElementu++;
            } while (indexElementu < teksty.Length);

            //pętla foreach
            Console.WriteLine("Wynik pętli foreach:");
            indexElementu = 0;
            foreach (var item in teksty)
            {
                //w foreach nie wolno edytować elementów item = "test";
                Console.WriteLine($"Pozycja {indexElementu++} = {item}");
            }
        }

        private static void KonstrukcjeJezyka()
        {
            //Komentarz jednoliniowy
            /* -początek komentarza wieloliniowego
              Komentarz wieloliniowy
                koniec komentarza wieloliniowego-    
                */
            //Typy danych
            /* Liczbowe:
             * całkowitoliczbowe: byte, int, long
             * ułamkowe: decimal, double
             * tekstowe: string, char, StringBuilder
             * daty: DateTime, TimeSpan
             */
            //Deklaracja zmiennej
            int a;
            a = 10; //Inicjowanie zmiennej przez przypisanie
            
            //int i System.Int32 to jest to samo. 
            System.Int32 b = 30; //deklaracja + inicjalizacja

            int c = a + b;//inicjowanie zmiennej wyrażeniem

            //To samo jak wyżej tylko na string'ach
            string tekst = "Hello";
            System.String tekst2;
            tekst2 = " demo";
            
            /*Rodzaje operatorów:
            Arytmetyczne: + - * / %
            Inkrementacji: ++, -- np. c++
            Porównania: ==, !=, <, >, <=, >=, is
            Łączenie tekstów (concatenation): +
            Logiczne: && (and), || (or)
            Przypisania: =, +=, *=, -=, /=
            Rzutowania: (), as
            Indeksowania: []
            Warunkowy: ?:
            */

            //Funkcja if i przykład użycia operatorów logiczny i porównania
            if ((a == b && a > 10) || b <= 20)
            {
                //jeżeli prawda
            }

            //Przykład opearatora is. Jeżeli tekst jest string to prawda
            if (tekst is string) { }

            //Operator przypisania +=
            a += 2;
            a = a + 2; //to jest to samo

            //Inkrementator
            a++; //najpierw używa potem powiększa o 1;
            ++a; //najpierw powiększa o jeden a potem używa zmiennej.

            //Operator konkatenacji (łączenia tekstów)
            tekst = tekst + tekst2;
            tekst += tekst2; //Operator przypisania += z operacją konkatenacji

            //Opeartor warunkowy ?: czyli jednoliniowy if.
            tekst = (a == 10) ? "tak" : "nie";

            //konwersja niejawna. Możliwa z mniejszego do większego (niezawsze).
            double z = a;
            //konwersja jawna
            a = (int)z; //Przykład użycia operatora rzutowania. Nie wszystkie typy mają to zaimplementowane.
                        //nie działa tekst = (string)a;

            //Konwersja niejawna
            int myInt = 20;
            long myLong = myInt;
            object objtest = myLong;

            //Konwersja jawna
            //checked //wymusza pełną kontrolę typów
            //{
            myLong = (long)int.MaxValue + 1;
            myInt = (int)myLong;
            Console.WriteLine(myInt);
            //}

            //KOnwersja string na int
            string kwotaString = "234";
            //NIe ma takiego rzutowania: decimal kwotaDec = (decimal)kwotaString;
            //Klasa konwert
            decimal kwotaDec = Convert.ToDecimal(kwotaString);
            Console.WriteLine(kwotaDec);

            //Metoda Parse
            kwotaDec = decimal.Parse(kwotaString);

            //Metoda TryParse
            if (decimal.TryParse(kwotaString, out kwotaDec))
            {

            }

            tekst = a.ToString();
       


            //Deklaracja typow wartościowych
            /* Nazwa zmiennej: 
            -nie może zaczynać się od liczby
            -nie może być nazwą kluczową np. int
            -nie może mieć spacji.
            */
            int typval = 20;
            int typval2 = typval; //kopiowanie stanu zmiennej

            //Deklaracja typów referencyjnych
            StringBuilder strBuild = new StringBuilder();
            StringBuilder strBuild2 = strBuild;


            //Dostęp do obiektu
            //Wywołanie metod instancji
            strBuild.Append("Hello");
            strBuild.Append("World");
            strBuild.ToString();

            //Wywoływanie metod klasy (Statycznych)
            //StringBuilder.Equals();
            //int.Parse();



            //IF
            if (a == 10)
            {
                //jeżeli a==10
            }
            else if (a > 50)
            {

            }
            else if (a > 100)
            {

            }
            else
            {

            }

            //case
            int w = 3;
            switch (w)
            {
                case 1:
                    Console.WriteLine("W=1");
                    break;
                case 2:
                    Console.WriteLine("W=2");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("W=3,4,5");
                    break;
                default:
                    Console.WriteLine("W>5");
                    break;
            }
        }

        static decimal konwertDoDecimal(string strLiczba)
        {

            return decimal.Parse(strLiczba);
        }

        //Przykład metody zwracajaca string
        public static string PobierzDane(string komunikat)
        {
            Console.Write($"{komunikat}:");
            return Console.ReadLine();
        }

        //Metoda nie zwracajaca wyniku
        static void Test()
        {
            Console.WriteLine("Obliczenia");
        }
    }

    class Obliczenia
    {
        public static decimal Dodawanie(decimal liczba1, decimal liczba2)
        {
            decimal wynik = liczba1 + liczba2;
            return wynik;
        }

        public static decimal Dodawanie(decimal liczba1, decimal liczba2, decimal liczba3)
        {
            return Dodawanie(liczba1, liczba2) + liczba3;
        }

        public static decimal Dodawanie(string liczba1, string liczba2)
        {
            decimal l1 = decimal.Parse(liczba1);
            decimal l2 = decimal.Parse(liczba2);

            return Dodawanie(l1, l2);
        }
    }
}
