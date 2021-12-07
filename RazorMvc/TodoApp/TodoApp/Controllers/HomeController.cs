using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Models;
using TodoApp.Services;

namespace TodoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TodoService _todoService;

        public HomeController(ILogger<HomeController> logger, TodoService todoService)
        {
            _logger = logger;
            _todoService = todoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SubmitNewTodo()
        {
            var emptyTodo = new TodoModel()
            {
                Todo = "Work to be done"
            };

            return View(emptyTodo);
        }

        public IActionResult TodoList(TodoModel todo)
        {
            _todoService.Add(todo);
            return RedirectToAction("SubmitNewTodo");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
