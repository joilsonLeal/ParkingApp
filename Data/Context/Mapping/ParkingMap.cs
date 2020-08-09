using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Context.Mapping
{
    public class ParkingMap : IEntityTypeConfiguration<Parking>
    {
        public void Configure(EntityTypeBuilder<Parking> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Description)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(t => t.RegisteredDate)
                .IsRequired();

            builder.HasOne(t => t.Country);

            builder.HasOne(t => t.User);

            builder.HasMany(t => t.Spots).WithOne(p => p.Parking);

            builder.ToTable("Parking");
        }
    }
}
