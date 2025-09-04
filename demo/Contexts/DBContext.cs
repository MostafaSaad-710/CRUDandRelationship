using demo.Congurations;
using demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.AuthScheme.PoP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Contexts
{
    internal class DBContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>( e =>
            //    {
            //        e.HasKey(e => e.EmpId);
            //        e.Property(e => e.EmpId).UseIdentityColumn(10, 10);
            //        e.Property(e => e.Name).HasColumnName("EmpName")
            //                               .HasColumnType("varchar")
            //                               .HasMaxLength(50)
            //                               .IsRequired();

            //    });

            modelBuilder.ApplyConfiguration(new EmployeeConf());
            modelBuilder.ApplyConfiguration(new DepartmentConf());

            #region 1to1
            //modelBuilder.Entity<Employee>().HasOne(E => E.department)
            //                               .WithOne(D => D.Manager)
            //                               .HasForeignKey<Department>(D => D.EmpId);

            modelBuilder.Entity<Department>().HasOne(D => D.Manager)
                                             .WithOne(E => E.department)
                                             .HasForeignKey<Department>(D => D.EmpId);

            #endregion

            modelBuilder.Entity<Department>().HasMany(D => D.Employees)
                                             .WithOne(E => E.WorkFor)
                                             .HasForeignKey(E => E.WorkForId);

            modelBuilder.Entity<StudentCourse>().HasKey(Sc => new {Sc .StudentId, Sc .CourseId});

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Code To Connect Database

            optionsBuilder.UseSqlServer("Server = . ; Database = CRUDandRelationship ; Trusted_Connection = True ; TrustServerCertificate = True ");
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }

    }
}
