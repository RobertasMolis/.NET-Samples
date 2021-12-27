using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreShop.Models
{
    public class ShopItemTag
    {
        public int ShopItemId { get; set; }
        public Shopitem Shopitem { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
