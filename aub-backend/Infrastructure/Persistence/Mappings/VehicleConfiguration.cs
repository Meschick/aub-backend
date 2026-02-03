using aub_backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aub_backend.Infrastructure.Persistence.Mappings
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("Vehicles");

            builder.HasKey(x => x.Id);

            builder.Property(p => p.Plate)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(p => p.Mark)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Model)
                .IsRequired()
                .HasMaxLength(50);  

            builder.HasOne( c => c.Customer)
                .WithMany( v => v.Vehicles)
                .HasForeignKey( c => c.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
