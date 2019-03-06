using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyDemo
{
    class Exceptions
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Start Programu");
                Oblicz();
                InfoKoniec();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
        }

        //Informacje koncowe
        static void InfoKoniec()
        {
            Console.Write("Koniec programu. Wciśnij ENTER");
            Console.ReadLine();
        }

        static void Oblicz()
        {
            bool jestBlad = false;
            do
            {
                try
                {
                    decimal l1 = KonwertujDoDecimal(PobierzDane("Podaj 1szą liczbę"));
                    decimal l2 = KonwertujDoDecimal(PobierzDane("Podaj 2gą liczbę"));
                    decimal wynikObliczen = Podziel(l1, l2);
                    Console.WriteLine($"{l1}/{l2}={wynikObliczen}");
                    jestBlad = false;
                }
                catch (DivideByZeroException)//kolejność catch ma znaczenie. Pierwszy pasujący jest używany
                {
                    Console.WriteLine("Błąd dzielenia przez 0");
                    throw new Exception("Błąd dzielenia");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Błąd formatowania");
                    jestBlad = true;
                }
                //catch (Exception ex)
                //{
                //    Console.WriteLine($"Błąd w oblicz: {ex.Message}");
                //} 
            } while (jestBlad);

        }
        
        static decimal Podziel(decimal l1, decimal l2)
        {
            decimal wynikDzielenia =0;
            try
            {
                wynikDzielenia = l1 / l2;
                return wynikDzielenia;
            }
            catch (DivideByZeroException ex) //obsługję błąd dzielenia przez zero
            {
                Console.WriteLine($"Błąd: {ex.Message}");
                throw; //Ponawiam błąd jeszcze raz
            }
        }

        static decimal KonwertujDoDecimal(string liczbaString)
        {
            var liczbaDecimal = decimal.Parse(liczbaString);
            return liczbaDecimal;
        }

        //Metoda pobierająca dane od użytkownika na konsoli
        static string PobierzDane(string komunikat)
        {
            Console.Write($"{komunikat}:");
            return Console.ReadLine();
        }

    }
}
