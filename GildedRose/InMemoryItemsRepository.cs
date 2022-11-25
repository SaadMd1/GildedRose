using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public class InMemoryItemsRepository : ItemsRepository
    {
        private List<Item> items = new List<Item>()
        {
            new GenericItem("Generic",10,10),
            new GenericItem("Generic",0,10),
            new GenericItem("Generic",5,0),
            new AgedItem("Aged Brie",5,5),
            new AgedItem("Aged Brie",5,50),
            new LegendaryItem("Sulfuras",5,80),
            new BackstagePasses("Backstage passes",15,5),
            new BackstagePasses("Backstage passes",10,5),
            new BackstagePasses("Backstage passes",5,5),
            new BackstagePasses("Backstage passes",0,5),
        };

        List<Item> ItemsRepository.GetInventory()
        {
            return items;
        }

        public void SaveInventory(List<Item> items)
        {
            this.items = items;
        }
    }
}
