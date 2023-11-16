﻿using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Infrastructure.Persistance.Configurations;

class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("Addresses");

        builder.Property(x => x.Country)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(x => x.City)
            .IsRequired()
            .HasMaxLength(200);
        builder.Property(x => x.Street)
            .IsRequired()
            .HasMaxLength(200);
        builder.Property(x => x.HausNumber)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(x => x.ZipCode)
            .IsRequired()
            .HasMaxLength(10);
        builder.Property(x => x.UserId)
            .IsRequired();
    }
}
