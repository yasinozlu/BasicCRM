using BasicCRM.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCRM.DataAccess.Concrete.EntityFramework
{
    public class SqlContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BasicCRM; Trusted_Connection=true");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
