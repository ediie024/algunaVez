using CalidadFinal.ConeccionBD.Maps;
using CalidadFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace CalidadFinal.ConeccionBD
{
    public class FinalContext: DbContext
    {
        public DbSet<Nota> notas { get; set; }
        public DbSet<Etiqueta> etiquetas { get; set; }
        public DbSet<DetalleNotaEtiqueta> DetalleNotaEtiquetas { get; set; }

        public FinalContext(DbContextOptions<FinalContext> options)
            : base(options) { }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          base.OnModelCreating(modelBuilder);
          modelBuilder.ApplyConfiguration(new DetalleNotaEtiquetaMap());
          modelBuilder.ApplyConfiguration(new NotaMap());  
          modelBuilder.ApplyConfiguration(new EtiquetaMap());


        }
    }
}