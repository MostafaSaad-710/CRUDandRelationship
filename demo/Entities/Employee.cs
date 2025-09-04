using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Entities
{
    internal class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double? Salary { get; set; }
        public string Address { get; set; }

        // One To One (Manage)
        public Department? department { get; set; } //Navigational Property

        // The importance of navigation property : when i create an object from a class in database
        // for example Employee, it returns data of employee
        // and also date of Department he manages it or works... what ever
        // but it's not a culomn in table in database

        //One To Many (Work)
        public int? WorkForId { get; set; }
        public Department? WorkFor { get; set; }

    }
}
