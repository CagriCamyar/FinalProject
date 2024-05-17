using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Contect : Db tabloları ile projenin classlarını bağlama
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //projem hangi Db ile ilişkili onu belli ediyoruz
        {
            optionsBuilder.UseSqlServer(@"Server =(localdb)\mssqllocaldb; Database=Northwind; Trusted_Connection =true");
        }

        public DbSet<Product> Products  { get; set; } //DbSet içerisinde Concrete klasöründeki dosya devamı ise tablo ismidir
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
