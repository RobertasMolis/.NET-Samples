using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreShop.Models
{
    public class Shopitem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        public DateTime ExpiryDate { get; set; } = DateTime.UtcNow;
    }
}
