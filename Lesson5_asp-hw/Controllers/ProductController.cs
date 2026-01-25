using Lesson5_asp_hw.Models;
using Lesson5_asp_hw.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Lesson5_asp_hw.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepository _repository;
        public const string Product = "Product";

        public ProductController(IRepository repository)
        {
                _repository = repository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NotFound()
        {
            return View();
        }
        public IActionResult GetAllProducts()
        {
            var products = _repository.GetAllProducts();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {

            var isAdded = _repository.Add(product);

            if (isAdded)
                return RedirectToAction(nameof(GetAllProducts));

            return View("Create", product);
        }

        
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult DeleteProduct(int id)
        {
            var isDeleted = _repository.Remove(id);
            if (isDeleted)
                return RedirectToAction(nameof(GetAllProducts));

            return View("Delete",id);
        }

       
        public IActionResult GetProductById(int id)
        {
            var product=_repository.GetProductById(id);
            if (product == null)
            {
                return RedirectToAction(nameof(NotFound));
            }
            return View(product);
        }
        [HttpGet]
        public IActionResult GetProductByPrice(decimal? minPrice, decimal? maxPrice)
        {
            var products = _repository.GetProductsByPrice(minPrice ?? 0, maxPrice ?? decimal.MaxValue);
            return View(products);
        }

    }
}
