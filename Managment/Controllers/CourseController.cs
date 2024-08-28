using Managment.Data;
using Managment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Managment.Controllers
{
    public class CourseController : Controller
    {
        private AppDbContext _appDbContext;

        public CourseController(AppDbContext appDbContext)
        {
            _appDbContext=appDbContext;
        }
        public IActionResult Index()
        {
            return View(_appDbContext.Courses);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Courses.Add(course);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index","Employee");
            }
            return View(course);
        }
    }
}
