using Microsoft.EntityFrameworkCore;
using MultipleDBContext.Models;

namespace MultipleDBContext.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
