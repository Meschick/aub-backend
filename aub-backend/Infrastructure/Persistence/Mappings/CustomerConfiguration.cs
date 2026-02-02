using aub_backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aub_backend.Infrastructure.Persistence.Mappings
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        // Fazemos todo o mapeamento da nossa entidade;
        // Restricoes

        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(155);

            builder.Property(x => x.Email)
                .IsRequired();
            
        }
    }
}
