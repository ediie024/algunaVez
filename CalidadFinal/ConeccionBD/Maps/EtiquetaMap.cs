using CalidadFinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CalidadFinal.ConeccionBD.Maps
{
    public class EtiquetaMap: IEntityTypeConfiguration<Etiqueta>
    {
        public void Configure(EntityTypeBuilder<Etiqueta> builder)
        {
            builder.ToTable("Etiqueta");
            builder.HasKey(o => o.Id);
            
            builder.HasMany(o => o.detalleNotaEtiquetas).
                WithOne(o=>o.etiqueta).
                HasForeignKey(o => o.IdEtiqueta);

        }
    }
}