using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{

    //context : Db tabloları ile proje classlarını bağlamak için kullanılır.
    public class NorthwindContext : DbContext
    {
        //hangi veri tabanına gideceğimizi söylüyoruz
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = 202-008;Database=Northwind; Persist Security Info=True;User ID = sa;Password=1234;"); //kurs

            /*optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-09UPACT\MSSQLSERVERR;Database=Northwind;Trusted_Connection=true");*/ //ev
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }  //veri tabanında hangi tabloya ne karşılık gelecek onu belirtiyoruz (projede->Category // dbde->Categories)
        public DbSet<Order> Orders { get; set; }
    }
}
