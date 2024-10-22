using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product pro1 = new Product();

            pro1.Id = 1;
            pro1.Name = "น้ำหวาน";
            pro1.Description = "น้ำผสมสารให้ความหวานแทนน้ำตาลอัดแก๊ส";

            Product pro2 = new Product();
            pro2.Id = 2;
            pro2.Name = "น้ำหวาน2";
            pro2.Description = "น้ำผสมสารให้ความหวานแทนน้ำตาลอัดแก๊ส";

            Product pro3 = new Product();
            pro3.Id = 3;
            pro3.Name = "น้ำหวาน3";
            pro3.Description = "น้ำผสมสารให้ความหวานแทนน้ำตาลอัดแก๊ส";

            List<Product> Allproducts = new List<Product>();
            Allproducts.Add(pro1);
            Allproducts.Add(pro2);
            Allproducts.Add(pro3);


            return View(Allproducts);
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
