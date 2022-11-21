using System;
using System.Collections.Generic;

namespace GildedRose
{
    public class Shop
    {

        public List<Item> items;

        public Shop(List<Item> items)
        {
            this.items = items;
        }

        public void UpdateQuality()
        {
            foreach(Item i in items)
            {
                i.Update();
            }
        }
    }
}