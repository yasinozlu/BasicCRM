using BasicCRM.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public DbSet<User> Users { get; set; }


        //public virtual IQueryable<Customer> GetCustomers2()
        //{
        //    return Set<Customer>.FromSql("dbo.GetCustomer");

        //}
        //public virtual DbSet<Customer> SpGetCustomerById { get; set; }
    }
}
