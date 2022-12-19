using DomainLayer.Tablolar;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.ID);//id pk yaptık
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.TcNo).IsRequired().HasMaxLength(13);
            builder.Property(x => x.Mail).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Gsm).IsRequired().HasMaxLength(12);
            //builder.Property(x => x.Plaka).HasMaxLength(12);
            //builder.Property(x => x.KullaniciAdi).IsRequired().HasMaxLength(50);
            //builder.Property(x => x.Sifre).IsRequired().HasMaxLength(50);
            builder.ToTable("Users");

        }
    }
}
