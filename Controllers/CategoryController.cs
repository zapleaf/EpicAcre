using EpicAcre.Data;
using EpicAcre.Models;
using Microsoft.AspNetCore.Mvc;

namespace EpicAcre.Controllers
{
    public class CategoryController : Controller
    {
        // AppDbContext comes from Dependancy Injection via the instructor
        private readonly AppDbContext _db;

        public CategoryController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category catObj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(catObj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(catObj);
        }
    }
}
