using Microsoft.AspNetCore.Mvc;
using BasicASP01.Models;
namespace BasicASP01.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int page = 1)
        {
            var Product1 = new Models.Product
            {
                Id = 01,
                Name = "Hiyo Jelly",
                Price = 20.00m,
                Quantity = 100,
            };
            var Product2 = new Models.Product
            {
                Id = 02,
                Name = "Lay",
                Price = 25.00m,
                Quantity = 200,
            };
            var Product3 = new Models.Product
            {
                Id = 03,
                Name = "Mama",
                Price = 15.00m,
                Quantity = 500,
            };
            var Product4 = new Models.Product
            {
                Id = 04,
                Name = "Chang noi",
                Price = 50.00m,
                Quantity = 1000,
            };
            var Product5 = new Models.Product
            {
                Id = 05,
                Name = "Pepsi",
                Price = 10.00m,
                Quantity = 1500,
            };
            var Product6 = new Models.Product
            {
                Id = 06,
                Name = "Coca Cola",
                Price = 25.00m,
                Quantity = 1000,
            };
            var Product7 = new Models.Product
            {
                Id = 07,
                Name = "Yum yum",
                Price = 20.00m,
                Quantity = 1050,
            };
            var Product8 = new Models.Product
            {
                Id = 08,
                Name = "Mirinda",
                Price = 15.00m,
                Quantity = 500,
            };
            var Product9 = new Models.Product
            {
                Id = 09,
                Name = "Gyoza",
                Price = 40.00m,
                Quantity = 2000,
            };
            var Product10 = new Models.Product
            {
                Id = 10,
                Name = "Ramen",
                Price = 80.00m,
                Quantity = 10000,
            };
            var Product = new List<Models.Product>();
            Product.Add(Product1);
            Product.Add(Product2);
            Product.Add(Product3);
            Product.Add(Product4);
            Product.Add(Product5);
            Product.Add(Product6);
            Product.Add(Product7);
            Product.Add(Product8);
            Product.Add(Product9);
            Product.Add(Product10);

            int pageSize = 3;
            int totalProducts = Product.Count;
            int totalPages = (int)Math.Ceiling((double)totalProducts / pageSize);

            var pagedProducts = Product
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return View(pagedProducts);
        }
    }
}
