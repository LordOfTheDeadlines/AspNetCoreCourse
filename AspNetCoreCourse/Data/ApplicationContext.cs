using AspNetCoreCourse.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreCourse.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options){}
    }
}
