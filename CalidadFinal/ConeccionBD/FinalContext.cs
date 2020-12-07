using Microsoft.EntityFrameworkCore;

namespace CalidadFinal.ConeccionBD
{
    public class FinalContext: DbContext
    {
    

        public FinalContext(DbContextOptions<FinalContext> options)
            : base(options) { }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          base.OnModelCreating(modelBuilder);



        }
    }
}