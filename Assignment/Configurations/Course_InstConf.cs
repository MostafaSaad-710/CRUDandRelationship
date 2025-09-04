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
    public class Course_InstConfiguration : IEntityTypeConfiguration<CourseInstructor>
    {
        public void Configure(EntityTypeBuilder<CourseInstructor> entity)
        {
            entity.HasKey(Cs => new {Cs.CourseID , Cs.InstructorID});
            entity.Property(ci => ci.InstructorID).HasColumnName("InstID");
            entity.Property(ci => ci.CourseID).HasColumnName("CourseID");
            entity.Property(ci => ci.evaluate).HasMaxLength(20);

        }
    }
}
