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
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> entity)
        {
            entity.HasKey(i => i.ID);
            entity.Property(i => i.ID).HasColumnName("InsID");
            entity.Property(i => i.Name).HasMaxLength(100).IsRequired();
            entity.Property(i => i.Bouns).HasColumnType("decimal(10,2)");
            entity.Property(i => i.Salary).HasColumnType("decimal(10,2)").IsRequired();
            entity.Property(i => i.Address).HasMaxLength(100);
            entity.Property(i => i.HourRate).HasColumnType("decimal(8,2)");
            entity.HasOne(i => i.department)
                  .WithOne(d => d.Work)
                  .HasForeignKey<Department>(d => d.Ins_ID);
        }
    }

}
