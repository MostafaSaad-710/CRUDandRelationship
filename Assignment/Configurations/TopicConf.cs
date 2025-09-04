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
    public class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> entity)
        {
            entity.HasKey(t => t.ID);
            entity.Property(t => t.ID).HasColumnName("TopicID");
            entity.Property(t => t.Name).HasMaxLength(100).IsRequired();
            entity.HasMany(C => C.Courses)
                  .WithOne(T => T.Ownerby)
                  .HasForeignKey(T => T.OwnerbyId);
        }
    }
}
