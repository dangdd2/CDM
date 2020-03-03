using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Tmag.Common;

namespace Tmag.Identity
{
    public class Context : DbContext
    {
        private readonly string _connectionString;

        public Context(IOptions<ConnectionStrings> settings)
        {
            _connectionString = settings.Value.MainDb;
        }
        public Context(string connectionString)
        {
            _connectionString = connectionString;
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<IdentityUserClaim<string>> IdentityUserClaims { get; set; }
    }
}
