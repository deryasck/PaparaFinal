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
    internal class MessegarConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(x => x.ID);//id pk yaptık
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.Konu).HasMaxLength(50);
            builder.Property(x => x.Acıklama).HasMaxLength(500);
            builder.Property(x => x.OkunduBilgisi).HasMaxLength(1);
            builder.HasOne(x=>x.User)
                .WithMany(x=>x.Messages)
                .HasForeignKey(x=>x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.ToTable("Messages");
        }
    }
}
