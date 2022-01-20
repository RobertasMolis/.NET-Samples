using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.Models;
using HotelApp.Repositories;

namespace HotelApp.Controllers
{
    public class CleanerController : Controller
    {
        private CleanerRepository _cleanerRepository;
        public CleanerController(CleanerRepository cleanerRepository)
        {
            _cleanerRepository = cleanerRepository;
        }

        public IActionResult Index()
        {
            return View(_cleanerRepository.GetAll());
        }

        public IActionResult Add()
        {
            Cleaner cleaner = new Cleaner();
            return View(cleaner);
        }

        [HttpPost]
        public IActionResult Add(Cleaner cleaner)
        {
            _cleanerRepository.Create(cleaner);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            Cleaner cleaner = _cleanerRepository.GetById(id);
            return View(cleaner);
        }

        [HttpPost]
        public IActionResult Update(Cleaner cleaner)
        {
            _cleanerRepository.Update(cleaner);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _cleanerRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
