using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Containers
{
    public abstract class SpecificContainer : Container
    {
        protected ItemType RequiredType;

        public SpecificContainer(int capacity, ItemType requiredType)
            : base(capacity)
        {
            RequiredType = requiredType;
        }

        public override bool AddItem(Item itemToAdd)
        {
            if (itemToAdd.Type != RequiredType)
            {
                return false;
            }

            return base.AddItem(itemToAdd);
        }
    }
}
