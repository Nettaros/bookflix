using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookflix.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookflix.Data
{
    public class BookflixContext : DbContext
    {
      

        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Reclamo> Reclamos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options )
        {
            options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookflixDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

    }
}
