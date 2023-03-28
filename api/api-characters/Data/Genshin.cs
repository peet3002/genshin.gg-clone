using Microsoft.EntityFrameworkCore;

class GenshinContext : DbContext
{
    public GenshinContext(DbContextOptions<GenshinContext> options)
        : base(options) { }

    public DbSet<CharacterModel> Characters => Set<CharacterModel>();
}