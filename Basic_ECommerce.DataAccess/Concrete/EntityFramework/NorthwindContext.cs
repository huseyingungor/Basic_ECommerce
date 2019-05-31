using Basic_ECommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_ECommerce.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HGUNGOR\SQLEXPRESS;Database=Northwind; Trusted_Connection=True");
        }

        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }
    }
}
