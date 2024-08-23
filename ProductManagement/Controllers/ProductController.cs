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
       
        public IActionResult Index(string searchTitle, DateTime? startDate, DateTime? endDate, int pageNumber = 1, int pageSize = 10)
        {
            var products = _db.Products.AsQueryable();

            if (!string.IsNullOrEmpty(searchTitle))
            {
                products = products.Where(p => p.Title.Contains(searchTitle));
            }

            if (startDate.HasValue)
            {
                products = products.Where(p => p.Date >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                products = products.Where(p => p.Date <= endDate.Value);
            }

            var paginatedProducts = products
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var totalProducts = products.Count();

            ViewBag.TotalPages = (int)Math.Ceiling((double)totalProducts / pageSize);
            ViewBag.CurrentPage = pageNumber;
            ViewBag.SearchTitle = searchTitle;
            ViewBag.StartDate = startDate?.ToString("yyyy-MM-dd");
            ViewBag.EndDate = endDate?.ToString("yyyy-MM-dd");

            return View(paginatedProducts);
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
