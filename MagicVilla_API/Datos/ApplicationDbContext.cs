using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {
            
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id= 1,
                    Nombre="villa real",
                    Detalle="detalle villa",
                    ImagenUrl="",
                    Ocupantes=5,
                    MetrosCuadrados=50,
                    Tarifa=200,
                    Amenidad="",
                    fechaActualizacion=DateTime.Now,
                    fechaCreacion=DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Nombre = "villa real2",
                    Detalle = "detalle villa2",
                    ImagenUrl = "",
                    Ocupantes = 54,
                    MetrosCuadrados = 0,
                    Tarifa = 2000,
                    Amenidad = "",
                    fechaActualizacion = DateTime.Now,
                    fechaCreacion = DateTime.Now
                }
                );
        }

    }
}
