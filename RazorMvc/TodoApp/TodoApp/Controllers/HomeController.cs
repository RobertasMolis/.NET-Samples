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

        public IActionResult Todo()
        {
            var todoModel = new TodoModel()
            {
                Todo = "Pailseti"
            };
            return View(todoModel);
        }

        public IActionResult SubmitNewTodo()
        {
            var emptyTodo = new TodoModel()
            {
                Todo = "Work to be done"
            };

            return View(emptyTodo);
        }
        [HttpPost]
        public IActionResult SubmitNewTodo(TodoModel todoItem)
        {
            _todoService.Add(todoItem);
            return View("Index");
        }
        
        public IActionResult TodoList()
        {
            var todos = _todoService.GetAll();

            var todoList = new TodoListModel()
            {
                Todos = todos
            };
            return View(todoList);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
