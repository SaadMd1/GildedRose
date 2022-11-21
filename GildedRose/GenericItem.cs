using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public class GenericItem : Item
    {
        public GenericItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void Update()
        {
            this.sellIn--;
            this.quality--;

            if (this.sellIn < 0)
                this.quality--;

            if (this.quality < 0)
                this.quality = 0;

            if (this.quality >= 50)
                this.quality = 50;

        }
    }
}
