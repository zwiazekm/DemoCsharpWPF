using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania1
{
    class Program
    {
        
        //Zadanie:
        /*Napisać program który poprosi o:
         * - nazwę zadania do wykonania
         * - termin wykonania
         * - priorytet (1-3)
         * - przełącznik czy zadanie jest opłatą
         * - jeżeli jest opłatą poprosić o kwotę.
         * - w przypadku braku kwota musi być 0.
         * Odbierane dane należy zapisać do zmiennych:
         * string nazwaZadania,
         * int priorytetZadania,
         * DateTime terminZadania,
         * bool opłata,
         * decimal kwotaZadania.
         * 
         * Należy utworzyć opis zadania na podstawie
         * powyższych zmiennych i zapisać do zmiennej 
         * string opisZadania
         * Na koniec program musi wyświetlić opisZadania
         */

        static void Main(string[] args)
        {
            string nazwaZadania = PobierzDane("Podaj nazwę zadania:");
            //Console.Write("Podaj termin:");
            //DateTime terminZadania =  DateTime.Parse( 
            //    Console.ReadLine());
            DateTime terminZadania = DateTime.Parse(
                PobierzDane("Podaj termin:"));
            Console.Write("Podaj priorytet zadania: (1-3)");
            int priorytetZadania = int.Parse(PobierzDane("Podaj priorytet zadania: (1-3)"));
            if (priorytetZadania <1 && priorytetZadania >3)
            {
                Console.WriteLine("Błędny priorytet");
                return;
            }
            Console.Write("Czy zadanie jest opłatą?:");
            string strCzyOplata = Console.ReadLine();
            bool opłata = 
                (strCzyOplata == "Tak" || strCzyOplata == "1") ? true : false;
            decimal kwotaZadania = 0;
            if (opłata)
            {
                Console.Write("Podaj kwotę:");
                kwotaZadania = decimal.Parse(Console.ReadLine());
            }
            //string opisZadania = "Zdanie tytuł: " + nazwaZadania + ", termin: " + terminZadania
            string opisZadania = string.Format(
                "Zadanie tytuł: {0}, termin:{1}, priorytet:{2}", 
                nazwaZadania, terminZadania, priorytetZadania);
            if (opłata)
            {
                opisZadania += $", kwota: {kwotaZadania}";
            }

            Console.WriteLine(opisZadania);

            Console.Write("Wciśnij ENTER");
            Console.ReadLine();
        }

        //Metoda pobierająca dane od użytkownika na konsoli
        static string PobierzDane(string komunikat)
        {
            Console.Write($"{komunikat}:");
            return Console.ReadLine();
        }
    }
}
