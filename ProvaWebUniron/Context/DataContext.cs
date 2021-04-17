using Microsoft.EntityFrameworkCore;
using ProvaWebUniron.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaWebUniron.Context
{
    public class DataContext : DbContext
    {
        //public DataContext()
        //{

        //}
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=provawebDB;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasKey(x => x.CodigoId);
            modelBuilder.Entity<Cliente>().HasKey(x => x.ClienteId);
        }

    }
}
