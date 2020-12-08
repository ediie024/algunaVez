using System;
using System.Collections.Generic;
using System.Linq;
using CalidadFinal.ConeccionBD;
using CalidadFinal.Models;
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

            ViewBag.busqueda = busqueda;
            ViewBag.etiquetas = _context.etiquetas.ToList();
            return View();
        }
        public IActionResult _Index(string busqueda="")
        {
                      var notas = _context.notas.ToList();
            var etiquetasBuscadas = new List<Etiqueta>();
            var etiquetas = _context.etiquetas.ToList();
            var DetalleNotasEtiquetas = _context.DetalleNotaEtiquetas.ToList();

            if (!string.IsNullOrEmpty(busqueda))
            {
                notas = _context.notas.Where(o => o.Titulo.ToLower().Contains(busqueda)|| o.Contenido.ToLower().Contains(busqueda)).ToList();
                etiquetasBuscadas = _context.etiquetas.Where(o => o.Nombre.ToLower().Contains(busqueda)).ToList();
            }

            var indicesEtiquetas = etiquetasBuscadas.Select(o => o.Id).ToList();
            List<DetalleNotaEtiqueta> nuevaIndices = new List<DetalleNotaEtiqueta>();
            foreach (var item in DetalleNotasEtiquetas)
            {
                if (indicesEtiquetas.Contains(item.IdEtiqueta))
                {
                    nuevaIndices.Add(item);
                }
            }

            var TNotas = _context.notas.ToList();
            List<Nota> nueva = new List<Nota>();
            var indiceDetalles = nuevaIndices.Select(o => o.IdNota).ToList();
            foreach (var item in TNotas)
            {
                if (indiceDetalles.Contains(item.Id))
                {
                    nueva.Add(item);
                }
            }

            var listaFinal = nueva.Union(notas);
            Dictionary<int,string> resumen = new Dictionary<int, string>();
            var contenido="";
            foreach (var item in listaFinal)
            {
                if (item.Contenido.Length<50)
                {
                    contenido = item.Contenido;
                }
                else
                {
                     contenido = item.Contenido.Substring(0, 50); 
                }

                resumen.Add(item.Id,contenido);
            }

            ViewBag.resumen = resumen;
            ViewBag.etiquetas = _context.etiquetas.ToList();
            ViewBag.detalles = DetalleNotasEtiquetas;
            return View(listaFinal);
            
        }

        public IActionResult CrearNota()
        {
            
            return View();
        }

        public IActionResult EliminarNotra(int IdNota)
        {
            var nota = _context.notas.Where(o => o.Id == IdNota).FirstOrDefault();
            _context.notas.Remove(nota);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult EditarNota(int IdNota)
        {
            ViewBag.Nota = _context.notas.Where(o => o.Id == IdNota).FirstOrDefault();
            return View();
        }
        public IActionResult EditarNotaA(Nota nota)
        {
            nota.UltimaModificacion = DateTime.Now;
            _context.notas.Update(nota);
            _context.SaveChanges();
            
             return RedirectToAction("Index");
        }
    }
}