using DomainLayer.Tablolar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataLayer.Configuration
{
    internal class DuesConfiguration : IEntityTypeConfiguration<Dues>
    {
        public void Configure(EntityTypeBuilder<Dues> builder)
        {
            builder.HasKey(x => x.ID);//id pk yaptık
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.Tutar).IsRequired();
            builder.Property(x => x.Odeme_Durumu).IsRequired();
            builder.HasOne(x => x.Housing)
                .WithMany(x => x.Dueses)
                .HasForeignKey(x => x.HousingId)
                .OnDelete(DeleteBehavior.SetNull);
            builder.ToTable("Dues");
        }
    }
}
