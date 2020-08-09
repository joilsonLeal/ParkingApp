﻿using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Context.Mapping
{
    public class SpotMap : IEntityTypeConfiguration<Spot>
    {
        public void Configure(EntityTypeBuilder<Spot> builder)
        {
            builder.HasKey(t => new { t.ParkingId, t.Number });

            builder.Property(t => t.Number)
                .IsRequired();

            builder.Property(t => t.IsRented)
                .IsRequired();

            builder.HasOne(t => t.Parking);

            builder.ToTable("Spot");
        }
    }
}
