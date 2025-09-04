using demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Congurations
{
    internal class DepartmentConf : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> b)
        {
            b.HasKey(e => e.Id);
            b.Property(e => e.Id).UseIdentityColumn(100, 100);
            b.Property(e => e.DeptName).HasColumnName("DeptName")
                                        .HasColumnType("varchar")
                                        .HasMaxLength(100);
        }
    }
}
