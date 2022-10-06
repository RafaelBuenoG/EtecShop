using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EtecShop.Models;
using Microsoft.EntityFrameworkCore;

namespace EtecShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categorias { get; set; }
        public DbSet<Product> Products { get; set; }
        
    }
}