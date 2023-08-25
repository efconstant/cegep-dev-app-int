using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple
{
    internal class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Item2(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
