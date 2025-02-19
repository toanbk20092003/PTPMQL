using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
namespace DemoMVC.Controllers
{
    public class BmiController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Bmi B)
        {
            float tb = B.weight/(B.hight*B.hight);
            if(tb<18.5 && tb>=0)
            {
                return "Gầy";
            }
            else if(tb>=18.5 && tb<=24.9)
            {
                return "Bình thường";
            }
            else if(tb>=25 && tb<=29.9)
            {
                return "Thừa cân";
            }
            else{
                return "Béo phì";
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    
    }
}