using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Schebeautyshop.Models
{
    public class SchebeautyshopContext : DbContext
    {
        public SchebeautyshopContext(DbContextOptions<SchebeautyshopContext> options) : base(options)
        {


        }

        public DbSet<Productos> Productos { get; set; } 
        public DbSet<CategoriasP> CategoriasPs { get; set; }    
        public DbSet<CategoriasS> CategoriasS { get; set;}
        public DbSet<Servicios> Servicios { get; set; }

    }




}

