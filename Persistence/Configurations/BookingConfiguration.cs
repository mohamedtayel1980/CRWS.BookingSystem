using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    internal sealed class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable(nameof(Booking));

            builder.HasKey(book => book.Id);

            builder.Property(book => book.Id).ValueGeneratedOnAdd();

            builder.Property(book => book.DateFrom)
                   .IsRequired();
            builder.Property(book => book.DateTo)
                   .IsRequired();

            builder.HasOne(book => book.Resource)
                    .WithMany()
                    .HasForeignKey(resource => resource.ResourceId)
                    .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
