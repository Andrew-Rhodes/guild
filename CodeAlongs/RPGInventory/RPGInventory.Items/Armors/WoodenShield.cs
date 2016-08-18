using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Armors
{
    public class WoodenShield : Item
    {
        public WoodenShield()
        {
            Name = "A wooden shield";
            Description = "Ouch, splinters";
            Weight = 2;
            Type = ItemType.Armor;
        }
    }
}
