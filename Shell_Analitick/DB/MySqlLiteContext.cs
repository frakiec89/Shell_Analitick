using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell_Analitick.DB
{
    public   class MySqlLiteContext : DbContext
    {
        private string conectionString = @"Data Source=DB\mydb.db;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(conectionString);
        }

        public DbSet<Model.Product> Products { get; set; }
        public DbSet<Model.ProductStorege> ProductStoreges { get; set; }
        public DbSet<Model.ProductType> ProductTypes { get; set; }

        public DbSet<Model.Sell> Sells { get; set; }

        public DbSet<Model.Seller> Sellers { get; set; }

        public DbSet<Model.Storege> Storeges { get; set; }


    }
}
