using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DealShareService.Contract
{
    public class Items
    {
        public List<Item> itemList { get; set; }
    }
    public class Item
    {
        public string Id { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public Uri ImageUrl { get; set; }
    }
}