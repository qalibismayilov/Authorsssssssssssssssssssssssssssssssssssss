using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WpfApp1.Models;

namespace WpfApp1.Congiration
{
    public class DepartmenCongiration : IEntityTypeConfiguration<Departmen>
    {
        public void Configure(EntityTypeBuilder<Departmen> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
