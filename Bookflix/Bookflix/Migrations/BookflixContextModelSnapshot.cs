﻿// <auto-generated />
using System;
using Bookflix.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bookflix.Migrations
{
    [DbContext(typeof(BookflixContext))]
    partial class BookflixContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bookflix.Models.Admin", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Bookflix.Models.Autor", b =>
                {
                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Nombre");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("Bookflix.Models.Categoria", b =>
                {
                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MaxPerfiles")
                        .HasColumnType("int");

                    b.HasKey("Nombre");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Bookflix.Models.Contenido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Dato")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("LibroId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LibroId");

                    b.ToTable("Contenido");
                });

            modelBuilder.Entity("Bookflix.Models.Editorial", b =>
                {
                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Nombre");

                    b.ToTable("Editoriales");
                });

            modelBuilder.Entity("Bookflix.Models.Genero", b =>
                {
                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Nombre");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("Bookflix.Models.Libro", b =>
                {
                    b.Property<int>("ISBN")
                        .HasColumnType("int");

                    b.Property<string>("AutorNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EditorialNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("GeneroNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Sinopsis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ISBN");

                    b.HasIndex("AutorNombre");

                    b.HasIndex("EditorialNombre");

                    b.HasIndex("GeneroNombre");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("Bookflix.Models.Novedad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("FechaOcultacion")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Video")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Novedades");
                });

            modelBuilder.Entity("Bookflix.Models.Perfil", b =>
                {
                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SubscriptorId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Nombre");

                    b.HasIndex("SubscriptorId");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("Bookflix.Models.PerfilLibros", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LibroISBN")
                        .HasColumnType("int");

                    b.Property<string>("PerfilId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("LibroISBN");

                    b.HasIndex("PerfilId");

                    b.ToTable("PerfilLibros");
                });

            modelBuilder.Entity("Bookflix.Models.Reclamo", b =>
                {
                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("PerfilId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Texto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FechaCreacion");

                    b.HasIndex("PerfilId");

                    b.ToTable("Reclamos");
                });

            modelBuilder.Entity("Bookflix.Models.Reseña", b =>
                {
                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("LibroId")
                        .HasColumnType("int");

                    b.Property<string>("PerfilId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte>("Puntaje")
                        .HasColumnType("tinyint");

                    b.Property<string>("Texto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FechaCreacion");

                    b.HasIndex("LibroId");

                    b.HasIndex("PerfilId");

                    b.ToTable("Reseña");
                });

            modelBuilder.Entity("Bookflix.Models.Subscriptor", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoriaNombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.HasIndex("CategoriaNombre");

                    b.ToTable("Subscriptores");
                });

            modelBuilder.Entity("Bookflix.Models.Tarjeta", b =>
                {
                    b.Property<string>("Dni")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CodigoSeguridad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubscriptorId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Dni");

                    b.HasIndex("SubscriptorId")
                        .IsUnique()
                        .HasFilter("[SubscriptorId] IS NOT NULL");

                    b.ToTable("Tarjeta");
                });

            modelBuilder.Entity("Bookflix.Models.Contenido", b =>
                {
                    b.HasOne("Bookflix.Models.Libro", "Libro")
                        .WithMany("Contenidos")
                        .HasForeignKey("LibroId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Bookflix.Models.Libro", b =>
                {
                    b.HasOne("Bookflix.Models.Autor", "Autor")
                        .WithMany("Libros")
                        .HasForeignKey("AutorNombre")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Bookflix.Models.Editorial", "Editorial")
                        .WithMany("Libros")
                        .HasForeignKey("EditorialNombre")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Bookflix.Models.Genero", "Genero")
                        .WithMany("Libros")
                        .HasForeignKey("GeneroNombre")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Bookflix.Models.Perfil", b =>
                {
                    b.HasOne("Bookflix.Models.Subscriptor", "Subscriptor")
                        .WithMany("Perfiles")
                        .HasForeignKey("SubscriptorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Bookflix.Models.PerfilLibros", b =>
                {
                    b.HasOne("Bookflix.Models.Libro", "Libro")
                        .WithMany("Lectores")
                        .HasForeignKey("LibroISBN")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Bookflix.Models.Perfil", "Perfil")
                        .WithMany("LibrosLeidos")
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Bookflix.Models.Reclamo", b =>
                {
                    b.HasOne("Bookflix.Models.Perfil", "Perfil")
                        .WithMany()
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Bookflix.Models.Reseña", b =>
                {
                    b.HasOne("Bookflix.Models.Libro", "Libro")
                        .WithMany("Reseñas")
                        .HasForeignKey("LibroId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Bookflix.Models.Perfil", "Perfil")
                        .WithMany()
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Bookflix.Models.Subscriptor", b =>
                {
                    b.HasOne("Bookflix.Models.Categoria", "Categoria")
                        .WithMany("Subscriptores")
                        .HasForeignKey("CategoriaNombre")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Bookflix.Models.Tarjeta", b =>
                {
                    b.HasOne("Bookflix.Models.Subscriptor", "Subscriptor")
                        .WithOne("Tarjeta")
                        .HasForeignKey("Bookflix.Models.Tarjeta", "SubscriptorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
