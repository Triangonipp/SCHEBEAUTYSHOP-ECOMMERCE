using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Schebeautyshop.Models;

namespace Schebeautyshop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly SchebeautyshopContext _context;
        public ProductsController(SchebeautyshopContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = _context.Productos.ToList();
            return View();
        }
    }
}
