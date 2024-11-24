using DoAnNam3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnNam3.Controllers
{
    public class ProductController : Controller
    {
        private readonly DoAnNam3 _doAnNam3;

        public ProductController(DoAnNam3 doAnNam3)
        {
            _doAnNam3 = doAnNam3;
        }
           
        public IActionResult Index()
        {
            return View();
        }

        [Route("/product/{alias}-{id}.html")]

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _doAnNam3.TblProduct == null)
            {
                return NotFound();
            }

            var product = await _doAnNam3.TblProduct.Include(i => i.CategoryProduct)
                .FirstOrDefaultAsync(m => m.ProductId  ==  id);
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.productReview = _doAnNam3.TblProductComment.
                where(i => i.ProductId == id && i.IsActive).ToList();
            ViewBag.productRelated = _doAnNam3.TblProduct.
                where(i => i.ProductId != id && i.CateId == product.CateId).Take(5).
                OrderByDescending(i => i.ProductId).Tolist();
        }
    }
}
