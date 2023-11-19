using Microsoft.EntityFrameworkCore;

namespace Schebeautyshop.Models
{
    public class SchebeautyshopContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public SchebeautyshopContext(DbContextOptions<SchebeautyshopContext> options) 
            : base(options)
        {


        }

        public DbSet<Productos> Productos { get; set; } 
        public DbSet<CategoriasP> CategoriasPs { get; set; }    

        public DbSet<CategoriasS> CategoriasS { get; set;}
        public DbSet<Servicios> Servicios { get; set; } 

    }


}

