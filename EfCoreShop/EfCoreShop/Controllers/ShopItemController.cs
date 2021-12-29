using EfCoreShop.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCoreShop.Models;
using Microsoft.EntityFrameworkCore;
using EfCoreShop.Dtos;

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
            List<Shopitem> shopItems =
                _context.Shopitems.Include(si => si.ShopItemTags).ThenInclude(t => t.Tag).ToList();

            return View(shopItems);
        }

        public IActionResult Add()
        {
            var createShopItem = new CreateShopItem()
            {
                Shopitem = new Shopitem(),
                AllShops = _context.Shops.ToList(),
                Tags = _context.Tags.ToList(), //ok tagai yra.
            };
            return View(createShopItem);
        }

        [HttpPost]
        public IActionResult Add(CreateShopItem createShopItem)
        {
            if (!ModelState.IsValid)
            {
                createShopItem.AllShops = _context.Shops.ToList();
                return View(createShopItem);
            }
            //cia kur nors breakpoint dek. ir tada ziek kas atkeliauja. jei ne null  galesi sukti cikla ir daryti kazka toliau. pabandyk  OK mėginisu
            _context.Shopitems.Add(createShopItem.Shopitem);
            _context.SaveChanges();

            foreach (var tagId in createShopItem.SelectedShopItemIds)  //ne pala. ne tas masyvas.  shhopitemIds yra tuscias. ir cia tau reikia tagu saraso. 
            {
                _context.ShopItemTags.Add(new ShopItemTag()
                {
                    TagId = tagId,
                    ShopItemId = createShopItem.Shopitem.Id
                });
            }

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
