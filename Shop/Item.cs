using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Item
    {

        public string Name { get; set; }
        public int Value { get; set; }

        public int Quantity { get; set; }

        public Item(string name, int value)
        {
            Name = name;
            Value = value;
        }

    }
}
