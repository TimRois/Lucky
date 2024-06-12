using Microsoft.EntityFrameworkCore;
using Lucky.Date.Models;
using Lucky.Date.Models.Account;

namespace Lucky.Date
{
    public class AppDbContent : DbContext
    {

        public AppDbContent(DbContextOptions<AppDbContent> options) : base(options)
        {

        }

        public DbSet<Pet> Pet { get; set; }
        public DbSet<Category> Category { get; set; }

        public DbSet<Order> Order { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }

        public DbSet<News> News { get; set; }


    }
}
