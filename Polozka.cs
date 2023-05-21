using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqNakupSeznam
{
    internal class Polozka
    {
        public string Nazev { get; private set; }
        public string Kategorie { get; private set; }

        public Polozka(string nazev, string kategorie)
        {
            Nazev = nazev;
            Kategorie = kategorie;
        }
        public Polozka(string nazev)
        {
            Nazev = nazev;
        }
    }
}
