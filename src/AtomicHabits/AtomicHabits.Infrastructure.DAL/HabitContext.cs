using AtomicHabits.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AtomicHabits.Infrastructure.DAL
{
    public class HabitContext : DbContext
    {
        public HabitContext(DbContextOptions<HabitContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<TokenSet> TokenSets { get; set; }
    }
}