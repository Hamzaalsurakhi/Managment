using Managment.Data;
using Managment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Managment.Controllers
{
    public class EmployeeController : Controller
    {
        private AppDbContext _appDbContext;

        public EmployeeController(AppDbContext appDbContext)
        {
            _appDbContext=appDbContext;
        }
        public IActionResult Index()
        {
            return View(_appDbContext.Employees);
        }

        public IActionResult Details(int? id)
        {
            if (id== null) {

                return RedirectToAction("Index");
            }
            var data = _appDbContext.Employees.Find(id);

            if (data==null)
            {
                return RedirectToAction("Index");
            }
            return View(data);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Employees.Add(employee);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");


            }

            return View(employee);
        }


        public IActionResult Edit(int? id)
        {
            if (id== null)
            {

                return RedirectToAction("Index");
            }
            var data = _appDbContext.Employees.Find(id);

            if (data==null)
            {
                return RedirectToAction("Index");
            }
            return View(data);

        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Employees.Update(employee);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");


            }
            return View(employee);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var data = _appDbContext.Employees.Find(id);
            if (data==null)
            {
                return RedirectToAction("Index");
            }
            return View(data);
        }
        public IActionResult ConfirmDelete(Employee employee, int EmployeeId) {

            var data = _appDbContext.Employees.Find(EmployeeId);
            if (data==null)
            {
                return RedirectToAction("Index");
            }
            _appDbContext.Employees.Remove(data);
            _appDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
                

        }
    }
    
}