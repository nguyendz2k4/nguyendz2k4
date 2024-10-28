using Microsoft.AspNetCore.Mvc;

namespace DoAnNam3.Controllers 
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
