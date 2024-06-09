using Microsoft.EntityFrameworkCore;
using MusicApi.Models.Config;

namespace MusicApi.Models;



public class AppDbContext : DbContext
{
    public virtual DbSet<Album> Albumy { get; set; }
    public virtual DbSet<Wytwornia> Wytornie { get; set; }
    public virtual DbSet<Utwor> Utory { get; set; }
    public virtual DbSet<Muzyk> Muzycy { get; set; }
    public AppDbContext()
    {
    }

    public AppDbContext (DbContextOptions options) : base(options)
    {
    }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AlbumEFConfig).Assembly);
    }
}