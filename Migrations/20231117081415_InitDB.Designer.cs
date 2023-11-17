﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Schebeautyshop.Models;

#nullable disable

namespace Schebeautyshop.Migrations
{
    [DbContext(typeof(SchebeautyshopContext))]
    [Migration("20231117081415_InitDB")]
    partial class InitDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Schebeautyshop.Models.CategoriasP", b =>
                {
                    b.Property<int>("CategoriasPID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriasPID"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriasPID");

                    b.ToTable("categoriasPs");
                });

            modelBuilder.Entity("Schebeautyshop.Models.CategoriasS", b =>
                {
                    b.Property<int>("CategoriasSID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriasSID"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriasSID");

                    b.ToTable("categoriasS");
                });

            modelBuilder.Entity("Schebeautyshop.Models.Productos", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<int>("CategoriasPID")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precio_p")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stock")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoriasPID");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Schebeautyshop.Models.Servicios", b =>
                {
                    b.Property<int>("ServicioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServicioID"));

                    b.Property<int>("CategoriasSID")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duracion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechayHoraDisponible")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precio_S")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sesiones")
                        .HasColumnType("int");

                    b.HasKey("ServicioID");

                    b.HasIndex("CategoriasSID");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("Schebeautyshop.Models.Productos", b =>
                {
                    b.HasOne("Schebeautyshop.Models.CategoriasP", "Categoriasp")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriasPID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoriasp");
                });

            modelBuilder.Entity("Schebeautyshop.Models.Servicios", b =>
                {
                    b.HasOne("Schebeautyshop.Models.CategoriasS", "CategoriasS")
                        .WithMany("Servicios")
                        .HasForeignKey("CategoriasSID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoriasS");
                });

            modelBuilder.Entity("Schebeautyshop.Models.CategoriasP", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Schebeautyshop.Models.CategoriasS", b =>
                {
                    b.Navigation("Servicios");
                });
#pragma warning restore 612, 618
        }
    }
}
