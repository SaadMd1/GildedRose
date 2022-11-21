using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public class AgedItem : Item
    {
        public AgedItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {

        }

        public override void Update()
        {
           

            this.sellIn--;
            this.quality++;



            if (this.quality < 0)
                this.quality = 0;

            if (this.quality >= 50)
                this.quality = 50;

        }
    }
}
