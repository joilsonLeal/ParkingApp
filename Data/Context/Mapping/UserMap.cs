using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Context.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(t => t.Password)
                .HasMaxLength(32)
                .IsRequired();

            builder.Property(t => t.IsActive)
                .IsRequired();

            builder.HasOne(t => t.Profile);

            builder.ToTable("User");
        }
    }
}
