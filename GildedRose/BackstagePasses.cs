using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public class BackstagePasses : Item
    {
        public BackstagePasses(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {

        }

        public override void Update()
        {
            this.sellIn--;
            this.quality++;


               
                if (this.sellIn < 10)
                    this.quality++;
                if (this.sellIn < 5)
                    this.quality++;
                if (this.sellIn < 0)
                    this.quality = 0;

          

        }
    }
}
