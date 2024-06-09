using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MusicApi.Models.Config;

public class UtworEFConfig: IEntityTypeConfiguration<Utwor>
{
    public void Configure(EntityTypeBuilder<Utwor> builder)
    {
        builder.HasKey(e => e.IdUtwor);
        builder.Property(e => e.IdUtwor).UseIdentityColumn();

        builder.Property(e => e.NazwaUtworu).IsRequired().HasMaxLength(30);
        builder.Property(e => e.CzasTrwania).IsRequired();

        builder.Property(e => e.IdAlbum);

        builder.HasOne(e => e.Album)
            .WithMany(a => a.Utwory)
            .HasConstraintName("Utwor_Album")
            .HasForeignKey(e => e.IdAlbum)
            .OnDelete(DeleteBehavior.Restrict);


        builder.ToTable("Utwor");
    }
}