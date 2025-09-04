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
    public class Stud_CourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> entity)
        {
            entity.HasKey(sc => new { sc.CourseID , sc.StudentID });
            entity.Property(sc => sc.StudentID).HasColumnName("StudID");
            entity.Property(sc => sc.CourseID).HasColumnName("CourseID");
            entity.Property(sc => sc.Grade).HasMaxLength(10);
        }
    }
}
