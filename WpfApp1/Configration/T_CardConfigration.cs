using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;
using WpfApp1.Models;

namespace WpfApp1.Congiration
{
    public class T_CardCongiration : IEntityTypeConfiguration<T_Card>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<T_Card> builder)
        {
            builder.HasOne<Books>()
           .WithMany()
           .HasForeignKey(x => x.Id_Book);

            builder.HasOne<Teacher>()
            .WithMany()
            .HasForeignKey(x => x.Id_Teacher);

            builder.HasOne<Lib>()
           .WithMany()
           .HasForeignKey(x => x.Id_Lib);

            builder.Property(b => b.DateIn)
             .IsRequired();


            builder.Property(b => b.DateOut)
              .IsRequired();

        }
    }
}
