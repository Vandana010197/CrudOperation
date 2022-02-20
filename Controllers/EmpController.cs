using CrudOperation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperation.Controllers
{
    public class EmpController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmpController(ApplicationDbContext db )
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displaydata = _db.Emp.ToList();
            return View(displaydata);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Create(NewEmp emp)
        {
            if (ModelState.IsValid)
            {
                _db.Add(emp);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(emp);
        }
        public async Task<IActionResult>Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getempdetails = await _db.Emp.FindAsync(id);
            return View(getempdetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(NewEmp emp)
        {
            if (ModelState.IsValid)
            {
                _db.Update(emp);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getempdetails = await _db.Emp.FindAsync(id);
            return View(getempdetails);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getempdetails = await _db.Emp.FindAsync(id);
            return View(getempdetails);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
           
            var getempdetails = await _db.Emp.FindAsync(id);
            _db.Emp.Remove(getempdetails);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
            return View(getempdetails);
        }


    }
}
