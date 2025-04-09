using Microsoft.EntityFrameworkCore;
using Poketcher.database.Entities.User;

namespace Poketcher.database.DBContext
{
    public class UserDbContext : DbContext
    {
        private readonly string _dbPath;

        public UserDbContext(string dbPath, DbContextOptions<UserDbContext> options) : base(options)
        {
            if (string.IsNullOrWhiteSpace(dbPath))
                throw new ArgumentException("Percorso del database non valido.", nameof(dbPath));

            _dbPath = dbPath;
        }

        public DbSet<UserPokemon> UserPokemon { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Data Source={_dbPath}");
            }
        }
    }
}
