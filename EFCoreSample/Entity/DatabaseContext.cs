using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


// Install-Package Microsoft.EntityFrameworkCore.SqlServer
// Install-Package Microsoft.EntityFrameworkCore.Tools -pre
// Add-Migration MyFirstMigration
// Update-Database

namespace EFCoreSample.Entity
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ProductionConnection"].ConnectionString);
        }

        public DbSet<Book> Books { get; set; }

    }


    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
