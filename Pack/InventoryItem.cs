using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pack
{
    public  class  InventoryItem
    {
        public double _weight { get; }
        public double _volume { get; }

        public InventoryItem(double weight, double volume)
        {
            _weight = weight;
            _volume = volume;
        }
    }

    public class Arrow : InventoryItem { public Arrow() : base(0.1, 0.05) { }
         public override string ToString() => "Arrow";
    }
    public class Bow : InventoryItem { public Bow() : base(1, 4) { } }
    public class Sword : InventoryItem { public Sword() : base(5, 3) { } }
    public class Ration : InventoryItem { public Ration() : base(1, 0.5) { } }
    public class Water : InventoryItem { public Water() : base(2, 3) { } }
    public class Rope : InventoryItem { public Rope() : base(1, 1.5) { } }
    public class Zero : InventoryItem { public Zero() : base(0, 0) { } }
}




