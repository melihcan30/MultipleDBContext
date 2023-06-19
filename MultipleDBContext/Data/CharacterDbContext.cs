using Microsoft.EntityFrameworkCore;
using MultipleDBContext.Models;

namespace MultipleDBContext.Data
{
    public class CharacterDbContext : DbContext
    {
        public CharacterDbContext(DbContextOptions<CharacterDbContext> options)
        : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }
    }
}
