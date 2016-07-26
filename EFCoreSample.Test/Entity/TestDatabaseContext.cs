using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreSample.Entity;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSample.Test.Entity
{
    public class TestDatabaseContext : DatabaseContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase();
        }
    }
}
