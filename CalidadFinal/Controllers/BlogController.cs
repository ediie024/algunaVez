using System.Linq;
using CalidadFinal.ConeccionBD;
using Microsoft.AspNetCore.Mvc;

namespace CalidadFinal.Controllers
{
    public class BlogController : Controller
    {
        private FinalContext _context;
        public BlogController(FinalContext _context)
        {
            this._context = _context;
        }

        public IActionResult Index(string busqueda)
        {
            var notas = _context.notas.ToList();
            var etiquetas = _context.etiquetas.ToList();
            var DetalleNotasEtiquetas = _context.DetalleNotaEtiquetas.ToList();

            if (!string.IsNullOrEmpty(busqueda))
            {
                notas = _context.notas.Where(o => o.Titulo.ToLower().Contains(busqueda)).ToList();
            }
            

            ViewBag.etiquetas = etiquetas;
            ViewBag.detalles = DetalleNotasEtiquetas;
            return View(notas);
        }

        public IActionResult CrearBlog()
        {
            return View();
        }
    }
}