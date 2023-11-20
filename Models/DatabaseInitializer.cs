using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Schebeautyshop.Models
{
    public class DatabaseInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<SchebeautyshopContext>();

                context.Database.EnsureCreated();

                // CategoriasS
                if (!context.CategoriasS.Any())
                {
                    var categoriasS = new List<CategoriasS>
                    {
                        new CategoriasS { Nombre = "Corte de cabello" },
                        new CategoriasS { Nombre = "Manicura" }
                    };
                    context.CategoriasS.AddRange(categoriasS);
                    context.SaveChanges();
                }

                // Servicios
                if (!context.Servicios.Any())
                {
                    var categoriaCorteCabello = context.CategoriasS.FirstOrDefault(c => c.Nombre == "Corte de cabello");
                    var categoriaManicura = context.CategoriasS.FirstOrDefault(c => c.Nombre == "Manicura");

                    var servicios = new List<Servicios>
                    {
                        new Servicios
                        {
                            Nombre = "Servicio 1",
                            Descripcion = "Descripción del Servicio 1",
                            Precio_S = 15.2,
                            Duracion = "1 hora",
                            Sesiones = 1,
                            FechayHoraDisponible = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            CategoriasS = categoriaCorteCabello // Asigna la primera categoría ficticia
                        },
                        new Servicios
                        {
                            Nombre = "Servicio 2",
                            Descripcion = "Descripción del Servicio 2",
                            Precio_S = 9.99,
                            Duracion = "45 minutos",
                            Sesiones = 2,
                            FechayHoraDisponible = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            CategoriasS = categoriaManicura // Asigna la segunda categoría ficticia
                        }
                    };
                    context.Servicios.AddRange(servicios);
                    context.SaveChanges();
                }
            }
        }
    }
}
