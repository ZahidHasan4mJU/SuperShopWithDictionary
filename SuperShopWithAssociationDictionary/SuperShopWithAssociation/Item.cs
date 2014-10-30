using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopWithAssociation
{
    class Item
    {
        public string ItemId { get; set; }
        public double  Quantity { get; set; }

        public Item(string id, double quantity):this()
        {
            ItemId = id;
            Quantity = quantity;
        }

        public Item()
        {
            
        }
    }
}
