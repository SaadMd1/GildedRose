using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public class LegendaryItem : Item
    {
        public LegendaryItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {

        }

        public override void Update()
        {
        }
    }
}
