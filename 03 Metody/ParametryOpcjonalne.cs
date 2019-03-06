using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyDemo
{
    class ParametryOpcjonalne
    {

        //Przykład metody z paramterem opcjonalnym
        //Paremtr opcjonalny posiada domyślną wartość
        public static void MetodaOpcja(string temat, 
                                       int status=1, decimal kwota=0)
        {
            Console.WriteLine(
                $"Temat={temat}, Status={status}, Kwota={kwota}");
        }
    }
}
