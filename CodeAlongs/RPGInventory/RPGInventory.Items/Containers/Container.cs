using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Containers
{
    public abstract class Container : Item
    {
        protected int Capacity;
        protected Item[] Items;
        protected int ItemIndex;

        public Container(int capacity)
        {
            Capacity = capacity;
            Items = new Item[capacity];

            Type = ItemType.Container;
        }

        public virtual bool AddItem(Item itemToAdd)
        {
            if (ItemIndex == Capacity)
            {
                return false;
            }

            if (Items.Contains(itemToAdd))
            {
                return false;
            }

            Items[ItemIndex] = itemToAdd;
            ItemIndex++;
            return true;
        }

        public Item RemoveItem()
        {
            if (ItemIndex == 0)
            {
                return null;
            }

            ItemIndex--;
            Item item = Items[ItemIndex];
            Items[ItemIndex] = null;
            return item;
        }
    }
}
