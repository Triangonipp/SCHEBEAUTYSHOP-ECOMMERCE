using Microsoft.AspNetCore.Mvc;
using Schebeautyshop.Models;

namespace Schebeautyshop.Controllers
{
    public class CategoriasPController : Controller
    {
        private readonly SchebeautyshopContext _context;
        public CategoriasPController(SchebeautyshopContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.CategoriasPs.ToList();
            return View();
        }
    }
}
