using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _08_BazyDanych
{
    class ZadaniaDB: DbContext
    {
        public DbSet<Zadanie> Zadania { get; set; }
    }

    public class Zadanie
    {
        public int IDZadanie { get; set; }
        public string Tytul { get; set; }
        public int Status { get; set; }
        public DateTime Termin { get; set; }
    }
}
