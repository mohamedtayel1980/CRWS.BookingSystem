using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations
{
    internal sealed class ResourceConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.ToTable(nameof(Resource));

            builder.HasKey(resource => resource.Id);

            builder.Property(resource => resource.Id).ValueGeneratedOnAdd();

            builder.Property(resource => resource.Name)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(resource => resource.Quantity).IsRequired();
        }
    }
}
