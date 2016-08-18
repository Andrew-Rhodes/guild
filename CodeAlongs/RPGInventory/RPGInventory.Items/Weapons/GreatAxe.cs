using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Weapons
{
    public class GreatAxe : Item
    {
        public GreatAxe()
        {
            Name = "A great axe";
            Description = "An axe, it's great.";
            Weight = 5;
            Type = ItemType.Weapon;
        }
    }
}
