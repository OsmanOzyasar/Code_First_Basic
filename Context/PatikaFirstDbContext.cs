using Code_First_Basic.Entities;
using Microsoft.EntityFrameworkCore;

namespace Code_First_Basic.Context
{
    public class PatikaFirstDbContext : DbContext
    {
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options) 
        {
            
        }

        public DbSet<MovieEntity> Movies => Set<MovieEntity>();
        public DbSet<GameEntity> Games => Set<GameEntity>();
    }
}
