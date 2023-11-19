using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Schebeautyshop.Models;

namespace Schebeautyshop.Controllers
{
    public class CategoriasSController : Controller

    {
        private readonly SchebeautyshopContext _context;
        public CategoriasSController(SchebeautyshopContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.CategoriasS.ToList();
            return View();
        }
    }
}

    