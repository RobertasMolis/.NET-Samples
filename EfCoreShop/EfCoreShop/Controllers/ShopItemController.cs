using EfCoreShop.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCoreShop.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreShop.Controllers
{
    public class ShopItemController : Controller
    {
        private DataContext _context;
        
        public ShopItemController(DataContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            List<Shopitem> shopItems = _context.Shopitems.Include().ToList(); // reik pabaigt
           
            return View(shopItems);
        }
    }
}
