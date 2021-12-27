using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreShop.Models
{
    public class Shopitem
    {
        public int Id { get; set; }
        [MinLength(2)][MaxLength(20)]
        public string Name { get; set; }
        public int ShopId { get; set; } = 2;
        public Shop Shop { get; set; }
        public DateTime ExpiryDate { get; set; } = DateTime.UtcNow;
        public List<ShopItemTag> ShopItemTags { get; set; }
    }
}
