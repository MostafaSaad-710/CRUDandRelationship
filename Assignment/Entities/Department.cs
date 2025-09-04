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
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public int? Ins_ID { get; set; }
        public Instructor? Work { get; set; }
    }

    
}
