using Microsoft.AspNetCore.Mvc;
using ProductManagement.Domain.Entities;
using ProductManagement.Infrastructure.Data;

namespace ProductManagement.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProductController(ApplicationDbContext db)
        { 
            _db = db;
        }
        public IActionResult Index()
        {
            var products = _db.Products.ToList();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(List<Product> products)
        {
            if (ModelState.IsValid)
            {
                foreach (var product in products)
                {
                    _db.Products.Add(product);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(products);
        }

    }
}
