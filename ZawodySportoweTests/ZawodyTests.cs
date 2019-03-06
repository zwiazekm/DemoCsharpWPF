using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZawodySportowe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZawodySportowe.Tests
{
    [TestClass()]//Atrybut
    public class ZawodyTests
    {
        [TestMethod()] 
        public void DodajZawodnikaTest()
        {
            //Faza aranżacji
            Zawody zawodyTestowe = new Zawody();
            string imie = "Testuś";
            string nazwisko = "Testowicz";
            int wiek = 20;
            string oczekiwane = $"{imie} {nazwisko}";
            //Faza wykonania
            zawodyTestowe.DodajZawodnika(imie, nazwisko, wiek);

            //Faza oceny
            var wynik = zawodyTestowe.ListaZawodnikow().Single();
            Assert.AreEqual(oczekiwane, wynik);
        }
    }
}