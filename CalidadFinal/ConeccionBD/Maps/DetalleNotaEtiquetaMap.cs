using CalidadFinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CalidadFinal.ConeccionBD.Maps
{
    public class DetalleNotaEtiquetaMap: IEntityTypeConfiguration<DetalleNotaEtiqueta>
    {
        public void Configure(EntityTypeBuilder<DetalleNotaEtiqueta> builder)
        {
            builder.ToTable("DetalleNotaEtiqueta");
            builder.HasKey(o => o.Id);
            
            
            builder.HasOne(o => o.nota).WithMany(o => o.detalleNotaEtiquetas).HasForeignKey(o => o.IdNota);
            builder.HasOne(o => o.etiqueta).WithMany(o => o.detalleNotaEtiquetas).HasForeignKey(o => o.IdEtiqueta);

        }
    }
}