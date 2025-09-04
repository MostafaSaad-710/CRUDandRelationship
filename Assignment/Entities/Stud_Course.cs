using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assighment.Entities
{
    public class StudentCourse
    {
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public string Grade { get; set; }
    }

     
}
