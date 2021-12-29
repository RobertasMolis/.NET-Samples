using EfCoreShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreShop.Dtos
{
    public class CreateShopItem
    {
        public Shopitem Shopitem { get; set; }
        public List<Shop> AllShops { get; set; }
        public List<int> SelectedShopItemIds { get; set; }
        public List<int> SelectedTagIds { get; set; } // i sita sudesi paselectintu tagu ids.
        public List<Tag> Tags { get; set; }
    }
}
