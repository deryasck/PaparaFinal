using DomainLayer.Tablolar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Configuration
{
    public class HouingConfiguration : IEntityTypeConfiguration<Housing>
    {
        public void Configure(EntityTypeBuilder<Housing> builder)
        {
            builder.HasKey(x => x.ID);//id pk yaptık
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.BlokNo).IsRequired();
            builder.Property(x => x.Tip).IsRequired();
            builder.Property(x => x.Kat).IsRequired();
            builder.Property(x => x.DaireNo).IsRequired();
            builder.Property(x => x.Durum).IsRequired();
            //bir kullanicinin birden fazla dairesi olabilir
            builder.HasOne(x => x.User)
                .WithMany(x => x.Housings) 
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.SetNull); //ilgili bir verinin silinmesi durumunda bağlantılı verilerin Null(hükümsüz) atanmasını sağlıyoruz.
            builder.ToTable("Housings");
           
        }
    }
}
