using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyDemo
{
    class ParametryOut
    {
        static void Main(string[] args)
        {
            //PrzykladyParameroRefOut();

            //Wywołanie metody z wszystkimi podanymi parametrami
            ParametryOpcjonalne.MetodaOpcja("Test1", 3, 30);
            //Wywołanie metody z pominięciem parametru opcjonalnego
            ParametryOpcjonalne.MetodaOpcja("Test2", 4);
            //Wywołąnie metody z nazwanymi argumentami
            ParametryOpcjonalne.MetodaOpcja("Test3", kwota: 200M);
            ParametryOpcjonalne.MetodaOpcja(
                kwota: 35M, temat: "Test4", status: 5);
        }

        private static void PrzykladyParameroRefOut()
        {
            int a = 10;
            int b = a; //kopiowanie wartości
            MetodaByVal(a); //wywołana metoda i przekopiowana wartość
            Console.WriteLine($"Wartość a po wykonaniu metody ByVal={a}");
            MetodaByRef(ref a);
            Console.WriteLine($"Wartość a po wykonaniu metody ByRef={a}");
            MetodaOut(out a);
            Console.WriteLine($"Wartość a po wykonaniu metody Out={a}");
        }

        //Przykład metody gdzie parametr będzie przekazny przez wartość
        static void MetodaByVal(int z)
        {
            z += 2;
            Console.WriteLine($"Wartość z w byVal={z}");
        }

        //Przykład metody gdzie parametr przekazywany jest przez referencję.
        static void MetodaByRef(ref int z)
        {
            z += 10;
            Console.WriteLine($"Wartość z w byRef={z}");
        }

        //Przykład metody z paramterem output.
        static void MetodaOut(out int z)
        {
            z = 30;
            Console.WriteLine($"Wartość z w out={z}");
        }

    }
}
