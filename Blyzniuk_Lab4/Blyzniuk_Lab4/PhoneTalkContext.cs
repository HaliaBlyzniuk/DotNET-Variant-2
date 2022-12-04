using Microsoft.EntityFrameworkCore;
using Blyzniuk_Lab4.Models;

namespace Blyzniuk_Lab4
{
    public class PhoneTalkContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<UserCity> UsersCities { get; set; }
        public PhoneTalkContext() { }
        public PhoneTalkContext(DbContextOptions<PhoneTalkContext> options): base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=PhoneTalk;Integrated Security=True");
    }
}
