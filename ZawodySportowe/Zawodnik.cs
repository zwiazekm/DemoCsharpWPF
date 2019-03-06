using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZawodySportowe
{
    public class Zawodnik
    {
        private string imie;
        private string nazwisko;
        private int wiek;
        private decimal wynik;

        //Własny konstruktor. 
        //Jeżeli tworzymy konstruktora, kompilator nie generuje domyślnego.
        public Zawodnik(string imie, string nazwisko, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            if (wiek < 0)
            {
                throw new FormatException("Nieprawidłowy wiek");
            }
            else
            {
                this.wiek = wiek;
            }
        }

        public string InfoZawodnik()
        {
            return $"{imie} {nazwisko}, Miasto: {Miasto}, Wiek {wiek}, Wynik: {wynik}";
        }

        public void ZapiszWynik(decimal wynik)
        {
            if (wynik < 0)
            {
                throw new FormatException("Błędny format wyniku");
            }
            this.wynik = wynik;
        }

        //Przykład property (właściwości)
        //Property jest metodami a używamy jak zmiennej
        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                if (value.Length == 0)
                {
                    throw new FormatException("Nieprawidłowe nazwisko");
                }
                nazwisko = value;
            }
        }
        public string Imie
        {
            //Z użyciem lambda
            get => imie;
            set
            {
                if (value.Length == 0)
                {
                    throw new FormatException("Nieprawidłowe imię");
                }
                imie = value;
            }
        }
        //Property readonly
        public decimal Wynik
        {
            get => wynik;
        }

        //Defaul property
        public string Miasto { get; set; }
    }
}
