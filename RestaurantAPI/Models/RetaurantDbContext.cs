using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class RetaurantDbContext: DbContext
    {
        public RetaurantDbContext(DbContextOptions<RetaurantDbContext> options):base (options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<FoodItem> foodItems { get; set; }
        public DbSet<OrderMaster> OrderMasters { get; set; }
    }
}
