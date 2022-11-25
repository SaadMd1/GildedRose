using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace GildedRose
{
    public class FileItemsRepository : ItemsRepository
    {
        public List<Item> GetInventory()
        {

            string line;
            List<Item> listOfItems = new List<Item>();
            var path = @"C:\\Users\\pc\\OneDrive - Ifag Paris\\Bureau\\EPSI COUR 4eme\\cv architecture  applicatives\\seance 1 le 02-11-2022\\gilded-rose-main\\csharpcore\\GildedRose\\File.txt";
            StreamReader file = new StreamReader(path);


            while ((line = file.ReadLine()) != null)
            {
                string[] properties = line.Split(',');
                
                switch (properties[0])
                {
                    case "Generic": listOfItems.Add(new GenericItem(properties[0], int.Parse(properties[1]), int.Parse(properties[2])));
                        break;

                    case "Aged":
                        listOfItems.Add(new AgedItem(properties[0], int.Parse(properties[1]), int.Parse(properties[2])));
                        break;

                    case "Backstage passes":
                        listOfItems.Add(new BackstagePasses(properties[0], int.Parse(properties[1]), int.Parse(properties[2])));
                        break;
                }

            }

            return listOfItems;
        }

        public void SaveInventory(List<Item> items)
        {
            
        }
    }
}
