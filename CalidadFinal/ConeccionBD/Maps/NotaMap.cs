using CalidadFinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CalidadFinal.ConeccionBD.Maps
{
    public class NotaMap : IEntityTypeConfiguration<Nota>
    {
        public void Configure(EntityTypeBuilder<Nota> builder)
        {
            builder.ToTable("Nota");
            builder.HasKey(o => o.Id);
            
            builder.HasMany(o => o.detalleNotaEtiquetas).
                WithOne(o=>o.nota).
                HasForeignKey(o => o.IdNota);

        }
    }
}