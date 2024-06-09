using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MusicApi.Models.Config;

public class AlbumEFConfig : IEntityTypeConfiguration<Album>
{
    public void Configure(EntityTypeBuilder<Album> builder)
    {
        builder.HasKey(e => e.IdAlbum);

        builder.Property(e => e.IdAlbum).UseIdentityColumn();

        builder.Property(e => e.NazwaAlbumu).IsRequired().HasMaxLength(30);
        builder.Property(e => e.DataWydania).IsRequired();

        builder.Property(e => e.IdWytwornia).IsRequired();

        builder.HasOne(e => e.Wytwornia)
            .WithMany(a => a.Albumy)
            .HasConstraintName("Album_Wytwornia")
            .HasForeignKey(e => e.IdWytwornia)
            .OnDelete(DeleteBehavior.Restrict);


        builder.ToTable("Album");

    }
}