using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Data.SqlClient;
using ZooApp.Services;

namespace ZooApp.Controllers
{
    public class ZooController : Controller
    {
        private readonly ILogger<ZooController> _logger;
        private readonly ZooService _zooService; 
        // GET: ZooControler

        public ZooController(ILogger<ZooController> logger, ZooService zooService)
        {
            _logger = logger;
            _zooService = zooService;
        }
        public IActionResult Index()
        {
            var show = _zooService.GetAll();
            return View(show);
        }

        // GET: ZooControler/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: ZooControler/Create
        public ActionResult Create()
        {
            return View(); //čia realiai susikursi tuščią zoo objektą ir paduosi į view.
                           ////view jį paėmęs galėsi užpildyti per inputus. paspaudus "save" atsiūsi duomenis į....
        }

        // POST: i sita create, post metodu.
        [HttpPost]
        
        public ActionResult Create(IFormCollection collection/*cia berods gali priimti id, arba visą objektą*/)
        {
          //service paima iš objekto duomenis, ir siuncia sql užklausą idejimo.
                return View();
            
        }

        // GET: ZooControler/Edit/5  edit panasiai kaip create. kazkur konkreciai nori kad issiplesciau?
        // kol kas pameginisiu, žinau kad kils klausimų, tada kreipsiuos 
        // tik klausimas ar bus kur padarytas visad sitas ? Nes per sian nespesiu, o ryt nelabai galimybiu turesiu daryt, busiu prisijunges tik kad prisijungti ir paklausyt
        //gerai priminei, padarysiu kaip su kita grupe. tai bus.
        // ok, bent pasinagrinet kaip atrodo, savaitgali pačiam pasimegint :) good luck
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ZooControler/Edit/5
        [HttpPost]
        
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ZooControler/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ZooControler/Delete/5
        [HttpPost]
        
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
