using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqNakupSeznam
{
    internal class Item
    {
        public string Name { get; private set; }
        public string Category { get; private set; }

        public Item(string name, string category)
        {
            Name = name;
            Category = category;
        }
        public Item(string nazev)
        {
            Name = nazev;
        }
    }
}
