using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {


            return View();
        }
    }
}
