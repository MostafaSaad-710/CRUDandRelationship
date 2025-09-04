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
    internal class EmployeeConf : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> e)
        {
            e.HasKey(e => e.EmpId);
            e.Property(e => e.EmpId).UseIdentityColumn(10, 10);
            e.Property(e => e.Name).HasColumnName("EmpName")
                                   .HasColumnType("varchar")
                                   .HasMaxLength(50)
                                   .IsRequired();
            e.Property(e => e.Salary).HasColumnType("decimal(18,2)").IsRequired(false);
        } 
    }
}
