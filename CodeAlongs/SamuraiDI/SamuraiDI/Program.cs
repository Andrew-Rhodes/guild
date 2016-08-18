using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamuraiDI.Items;

namespace SamuraiDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Samurai bob = new Samurai(new Sword());
            bob.Attack("the bad dudes");

            bob.SecondaryWeapon = new Sword();
            if (bob.SecondaryWeapon != null)
            {
                bob.SecondaryWeapon.Hit("the other guy");
            }

            Samurai jack = new Samurai(new Shuriken());
            jack.Attack("the evildoers");

            jack.PickupItem(new Ration());
            jack.PickupItem(new Ration());
            jack.PickupItem(new Ration());
            jack.PickupItem(new Ration());
            jack.PickupItem(new Ration());
            jack.PickupItem(new Ration());
            jack.PickupItem(new Ration());

            Console.ReadLine();
        }
    }
}
