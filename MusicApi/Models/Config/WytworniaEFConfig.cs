using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MusicApi.Models.Config;

public class WytworniaEFConfig : IEntityTypeConfiguration<Wytwornia>
{


    public void Configure(EntityTypeBuilder<Wytwornia> builder)
    {
        builder.HasKey(e => e.IdWytwornia);

        builder.Property(e => e.IdWytwornia).UseIdentityColumn();

        builder.Property(e => e.Nazwa).IsRequired().HasMaxLength(50);

        builder.ToTable("Wytwornia");
    }
}