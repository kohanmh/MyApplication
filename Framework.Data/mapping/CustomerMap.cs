using Framework.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Framework.Data.mapping
{
    public class CustomerMap : IEntityTypeConfiguration<CustomerEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder
               .ToTable("Customer", "dbo");

            builder
                .HasKey(x => x.Key)
                .HasName("ID");


            builder.Property(x => x.NationalId)
                .HasColumnName("NationalID");


            builder
                .Property(x => x.FirstName)
                .HasColumnName("FirstName");

            builder
                .Property(x => x.LastName)
                .HasColumnName("LastName");
        }
    }
}
