using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Store.AuUser;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.DataFolder
{
    /// <summary>
    /// контекст базы данныхS
    /// </summary>
    public class StoreContext : IdentityDbContext<User>
    {

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        
        public StoreContext() { }


        public StoreContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ///Изменить строку подключения
            optionsBuilder.UseSqlServer(
                 @"Server=(LocalDB)\MSSQLLocalDB;
                     Database=StoreDB.mdf;
                    Trusted_Connection=True;"
                );
        }
    }
}
