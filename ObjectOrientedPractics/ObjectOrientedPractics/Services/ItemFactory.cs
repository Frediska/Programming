using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    public static class ItemFactory
    {
        public static Item Randomize()
        {
            Item item = new Item();
            item.Name = "Name";
            item.Cost = 1;
            item.Info = "info";

            return item;
        }
    }
}
