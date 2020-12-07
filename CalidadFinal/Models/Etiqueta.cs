using System.Collections.Generic;

namespace CalidadFinal.Models
{
    public class Etiqueta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        
        public List<DetalleNotaEtiqueta> detalleNotaEtiquetas { get; set; }
    }
}