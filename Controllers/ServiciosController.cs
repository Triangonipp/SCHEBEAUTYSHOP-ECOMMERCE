using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Schebeautyshop.Models;

namespace Schebeautyshop.Controllers
{
    public class ServiciosController : Controller
    {
        private readonly SchebeautyshopContext _context;
        public ServiciosController(SchebeautyshopContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = _context.Servicios.ToList(); return View();
        }
    }
}
