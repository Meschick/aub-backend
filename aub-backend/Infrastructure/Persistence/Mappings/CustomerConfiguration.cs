using aub_backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aub_backend.Infrastructure.Persistence.Mappings
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(155);

            builder.Property(x => x.Email)
                .IsRequired();

            builder.Property(x => x.Telephone)
                .HasMaxLength(11);

            builder.Property(x => x.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            builder.Property(x => x.CustomerStatus)
                .HasConversion<int>()
                .IsRequired();
        }
    }
}
