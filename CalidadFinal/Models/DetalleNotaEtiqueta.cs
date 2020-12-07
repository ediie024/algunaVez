namespace CalidadFinal.Models
{
    public class DetalleNotaEtiqueta
    {
        public int Id { get; set; }
        public int IdNota { get; set; }
        public int IdEtiqueta { get; set; }

        public Etiqueta etiqueta { get; set; }
        public Nota nota { get; set; }
    }
}