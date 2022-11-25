using System;
using System.Collections.Generic;

namespace GildedRose
{
    public class Shop
    {

        public ItemsRepository itemsRepository; 

        public Shop(ItemsRepository itemsRepository)
        {
            this.itemsRepository = itemsRepository;
        }

        public void UpdateQuality()
        {
            var items= this.itemsRepository.GetInventory();
            foreach(Item i in items)
            {
                i.Update();
            }
            this.itemsRepository.SaveInventory(items);
        }
    }
}