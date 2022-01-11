using HotelApp.Data;
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
    public class HotelController : Controller
    {
        private HotelRepository _hotelRepository;
        public HotelController(HotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public IActionResult Index()
        {
            return View(_hotelRepository.GetAll());
        }

        public IActionResult Add()
        {
            Hotel hotel = new Hotel();
            return View(hotel);
        }

        [HttpPost]
        public IActionResult Add(Hotel hotel)
        {
            _hotelRepository.Create(hotel);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            Hotel hotel = _hotelRepository.GetById(id);
            return View(hotel);
        }

        [HttpPost]
        public IActionResult Update(Hotel hotel)
        {
            _hotelRepository.Update(hotel);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _hotelRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
