using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopWithAssociation
{
    class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }
        //public List<Item> Items { get; set; }
        public Dictionary<string, Item> Items2 { set; get; } 
        public string Msg { get; set; }
        
        public Shop(string name, string address)
        {
            Name = name;
            Address = address;
            //Items = new List<Item>();
            Items2 = new Dictionary<string, Item>();
            Msg = "Id" + "\t" + "Quantity" + "\n";

        }

        public string add(Item anItem)
        {
            if (hasThisIdValid(anItem.ItemId))
            {
                foreach (KeyValuePair<string, Item> item2 in Items2)
                {
                    if (item2.Key == anItem.ItemId)
                    {
                        Item item3 = item2.Value;
                        item3.Quantity += anItem.Quantity;
                        
                    }
                 }
                return "Updated";
            }
            Items2.Add(anItem.ItemId, anItem);
            //Items.Add(anItem);
            return "Added";
        }

        public bool hasThisIdValid(string id)
        {
            foreach (KeyValuePair<string, Item> item2 in Items2)
            {
                if (item2.Key == id)
                {
                    return true;
                }
                
            }
            return false;
        }

        public string getResult()
        {
           Item anItem = new Item();
           foreach( KeyValuePair<string , Item> items1 in Items2)
           {
               string m = items1.Key;
               Item a = items1.Value;
               Msg += m + "\t    " + a.Quantity + "\n";

           }
            return Msg;

        }

        //public void updateItem(Item anItem)
        //{
        //    foreach (Item item2 in Items)
        //    {
        //        if (item2.ItemId == anItem.ItemId)
        //        {
        //            item2.Quantity += anItem.Quantity;

        //        }
        //    }
        //}
    }
}
