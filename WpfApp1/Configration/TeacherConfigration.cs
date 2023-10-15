using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WpfApp1.Models;

namespace WpfApp1.Configration
{
        public class TeacherConfigration : IEntityTypeConfiguration<Department>
        {
            public void Configure(EntityTypeBuilder<Department> builder)
            {
                throw new NotImplementedException();
            }
        }
    
}
