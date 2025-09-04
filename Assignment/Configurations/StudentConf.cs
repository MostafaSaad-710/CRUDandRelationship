using Assighment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assighment.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> entity)
        {
            entity.HasKey(s => s.ID);
            entity.Property(s => s.ID).HasColumnName("StudID");
            entity.Property(s => s.FName).HasMaxLength(50).IsRequired();
            entity.Property(s => s.LName).HasMaxLength(50).IsRequired();
            entity.Property(s => s.Address).HasMaxLength(100);
            entity.Property(s => s.Age).IsRequired();
            //entity.Property(s => s.Dep_Id).IsRequired();
        }
    }
}
