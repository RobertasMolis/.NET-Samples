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
            List<Shopitem> shopItems = _context.Shopitems.Include(x => x.Shop).ToList();
           
            return View(shopItems);
        }

        public IActionResult Add()
        {
            var shopItem = new Shopitem();
            return View(shopItem);

        }

        [HttpPost]
        public IActionResult Add(Shopitem shopitem)
        {
            if (!ModelState.IsValid)
            {
                return View(shopitem);
            }
            _context.Shopitems.Add(shopitem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var shopItem = _context.Shopitems.Find(id);
            _context.Shopitems.Remove(shopItem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var shopItem = _context.Shopitems.Find(id);
            return View(shopItem);
        }

        [HttpPost]
        public IActionResult Update(Shopitem shopitem)
        {
            _context.Shopitems.Update(shopitem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
