using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ignitis.Data;
using Ignitis.Models;
using System.Linq;

namespace Ignitis.Controllers
{
    public class FormController : Controller
    {
        private DataContext _dataContext;
        public FormController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var form = _dataContext.Forms.Include(f => f.Questions).ThenInclude(q => q.PossibleAnswers).FirstOrDefault();
            return View(form);
        }
        
        //public IActionResult Submit(Form form)
        //{
        //    _dataContext.Update(form);
        //    _dataContext.SaveChanges();

        //    return RedirectToAction("Index");
        //}
    }
}
