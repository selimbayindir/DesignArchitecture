using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class DesignArchitectureContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=BYNDR\\PIPLE;Initial Catalog=DesignArchitecture;User ID=dw;Password=Perkon123456;");
        }
        public DbSet<Person> People { get; set; }
    }
}
