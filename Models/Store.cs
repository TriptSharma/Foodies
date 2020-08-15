using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foodies.Models
{
    //Name, Branch, Menu,
    public class Store
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public IEnumerable<Dish> Menu { get; set; }
        public List<StoreBranch> StoreBranch { get; set; }
    }
}