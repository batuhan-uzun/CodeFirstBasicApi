using CodeFirstBasicApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasicApi.Context
{
    public class CodeFirstDbContext : DbContext
    {
        public CodeFirstDbContext(DbContextOptions<CodeFirstDbContext> options) : base(options)
        {

        }

        DbSet<GameEntity> Games => Set<GameEntity>();
        DbSet<MovieEntity> Movies => Set<MovieEntity>();
    }
}
