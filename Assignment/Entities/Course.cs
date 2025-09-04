using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assighment.Entities
{
    // 1. Convention Way
    public class Course
    {
        public int ID { get; set; }
         public string Name { get; set; }
        public string Description { get; set; }
        public int? OwnerbyId { get; set; }
        public Topic? Ownerby { get; set; }

        public List<CourseInstructor>  courseInstructors { get; set; }
        public List<StudentCourse> studentCourses { get; set; }
    }

    
}
