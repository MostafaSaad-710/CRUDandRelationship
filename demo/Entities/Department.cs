using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }

        // One To One (MAnage)
        ////[ForeignKey("Manager")]
        ////[ForeignKey(nameof(Department.Manager))]
         public int EmpId { get; set; } //Fk
         public Employee Manager { get; set; }  

        // One To Many (Work
        public List<Employee> Employees { get; set; }

    }
}
