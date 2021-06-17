using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ExpenseController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Expense> objList = _db.expenses;
          
            return View(objList);
        }
        public IActionResult Create()
        {
          //  IEnumerable<Item> objList = _db.items;
            return View();
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense obj)
        {
            //  IEnumerable<Item> objList = _db.items;
            _db.expenses.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
