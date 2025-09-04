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
    public class Topic
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Course> Courses { get; set; }
    }

     
}
