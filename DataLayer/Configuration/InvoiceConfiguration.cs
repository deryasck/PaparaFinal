using DomainLayer.Tablolar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Configuration
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {

        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.HasKey(x => x.ID);//id pk yaptık
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.Tutar).IsRequired();
            //bir dairenin birden fazla faturası olabilir
            builder.HasOne(x => x.User)
                 .WithMany(x => x.Invoices)
                 .HasForeignKey(x => x.UserId)
                 .OnDelete(DeleteBehavior.SetNull);

            builder.ToTable("Invoices");
        }
    }
}
