using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesApp1.Models
{
    public class CourseVM
    {
        public int Id { get; set; }
        public int CourseName { get; set; }
        public int CategoryId { get; set; }
        public int Source { get; set; }
        public int Level { get; set; }

    }
}
