using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    //TODO
    /*rendre cette classe abstract 
     *rendre la methode update() en abstract
     *pour chaque type il faut creer une classe qui hérite de Item
     *
     */
    //[Table("Item")]
    public abstract class Item
    {
        //[Column("test")]
        protected string name;
        protected int sellIn;
        protected int quality;

        public string Name {

            get { return name; }
            set { name = value; } 
        }
        
        public int SellIn
        {
            get { return sellIn; }
            set { sellIn = value; }
        }

        public int Quality
        {
            get { return quality; }
            set { quality = value; }
        }

        public Item(string name, int sellIn, int quality)
        {
            this.name = name;
            this.sellIn = sellIn;
            this.quality= quality;
        }



        public abstract void Update();
        
          /*  if (this.name == "Sulfuras")
                return;

            this.sellIn--;
            if (this.name == "Backstage passes")
            {
                this.quality++;
                if (this.sellIn < 10)
                    this.quality++;
                if (this.sellIn < 5)
                    this.quality++;
                if (this.sellIn < 0)
                    this.quality = 0;

            }

            else if (this.name == "Aged Brie" )
                this.quality++;

            else
            {
                this.quality--;

                if (this.sellIn < 0)
                    this.quality--;
            } 

            if (this.quality < 0)
                this.quality = 0;

            if (this.quality >= 50)
                this.quality = 50;

           
        */


    }
}
