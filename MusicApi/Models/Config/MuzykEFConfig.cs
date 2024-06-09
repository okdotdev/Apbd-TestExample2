using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MusicApi.Models.Config;

public class MuzykEFConfig : IEntityTypeConfiguration<Muzyk>
{
    public void Configure(EntityTypeBuilder<Muzyk> builder)
    {
        builder.HasKey(e => e.IdMuzyk);
        builder.Property(e => e.IdMuzyk).UseIdentityColumn();

        builder.Property(e => e.Imie).IsRequired().HasMaxLength(30);
        builder.Property(e => e.Nazwisko).IsRequired().HasMaxLength(40);

        builder.Property(e => e.Nazwisko).HasMaxLength(50);

        builder.ToTable("Muzyk");
    }
}