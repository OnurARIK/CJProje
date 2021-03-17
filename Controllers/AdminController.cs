using CJProje.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CJProje.Controllers
{
    public class AdminController : Controller
    {

        public AdminController()
        {
            List<Brand> brands = new List<Brand>()
            {
                new Brand(){Id=1,BrandName="Adidas"},
                new Brand(){Id=2,BrandName="Nike"},
            };

            List<Product> products = new List<Product>()
            {
                new Product(){Id=1,BrandId=1,BrandName="Adidas", ProductName="Samoa",Ocak=125000,Şubat=175000,Mart=150000,Nisan=145000,Mayıs=250000,Haziran=185000,Temmuz=185000,Ağustos=300000,Eylül=450000,Ekim=150000,Kasım=250000,Aralık=300000},

                new Product(){Id=2,BrandId=1,BrandName="Adidas", ProductName="SuperStar",Ocak=150000,Şubat=175000,Mart=250000,Nisan=185000,Mayıs=300000,Haziran=150000,Temmuz=150000,Ağustos=125000,Eylül=300000,Ekim=300000,Kasım=150000,Aralık=175000},

                new Product(){Id=3,BrandId=2,BrandName="Nike", ProductName="Air",Ocak=150000,Şubat=175000,Mart=250000,Nisan=185000,Mayıs=300000,Haziran=150000,Temmuz=150000,Ağustos=125000,Eylül=300000,Ekim=300000,Kasım=150000,Aralık=175000},

                new Product(){Id=4,BrandId=2,BrandName="Nike", ProductName="Metcon",Ocak=250000,Şubat=185000,Mart=185000,Nisan=300000,Mayıs=450000,Haziran=150000,Temmuz=250000,Ağustos=300000,Eylül=125000,Ekim=175000,Kasım=150000,Aralık=145000},
            };
            Products = products;
            Brands = brands;            
        }
        public List<Brand> Brands { get; set; }
        public List<Product> Products { get; set; }
        [HttpGet]
        public IActionResult Index()
        {
            AdminWM vm = new AdminWM();
            vm.Products = Products;
            vm.Brands = Brands;
            return View(vm);
        }
        public JsonResult GetProductDataForChart(int id)
        {
            var product = Products.Where(x => x.Id == id).FirstOrDefault();

            return Json(product);
        }
    }
}

