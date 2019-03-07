using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person()
            {
                Name = "Jerzy Test",
                Age = 30
            };

            Person p2 = p1;
            p2.Age = 45;
            Console.WriteLine(p1.Age);

            Adress a1 = new Adress()
            {
                Street = "Kwiatowa 10",
                City = "Katowice"
            };
            Adress a2 = a1;
            a2.City = "Sosnowiec";
            Console.WriteLine(a1.City);
            Status s1 = Status.Wykonywane;
            s1 = (Status)3;
            Console.WriteLine(s1);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    //Typ wartościowy
    struct Adress
    {
        public string Street;
        public string City;
    }

    enum Status
    {
        Planowane=1,
        Wykonywane,
        Zatwierdzone,
        Anulowane =-1
    }
}
