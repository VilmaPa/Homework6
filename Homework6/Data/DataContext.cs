using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework6.Models;

namespace Homework6.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Fruit> Fruits { get; set; }

        public DbSet<Shop> Shops { get; set; }

        public DbSet<Dish> Dishes { get; set; }

        public DbSet<Vegetable> Vegetables { get; set; }
    }
}
