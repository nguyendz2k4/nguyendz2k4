using Microsoft.AspNetCore.Mvc;

namespace DoAnNam3.Controllers
{
    public class _404Controller : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
    }
}
