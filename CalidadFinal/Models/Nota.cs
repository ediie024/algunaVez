using System;
using System.Collections.Generic;

namespace CalidadFinal.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime UltimaModificacion { get; set; }
        public string Contenido { get; set; }

        public List<DetalleNotaEtiqueta> detalleNotaEtiquetas { get; set; }
    }
}