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
        public DbSet<CategoriasP> categoriasPs { get; set; }    

    }

}

