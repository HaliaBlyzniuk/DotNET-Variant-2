using Microsoft.EntityFrameworkCore;
using Blyzniuk_Lab_2.Models;

namespace Blyzniuk_Lab_2
{
    class PhoneTalkContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<UserCity> UsersCities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=PhoneTalk;Integrated Security=True");
        }
    }
}
