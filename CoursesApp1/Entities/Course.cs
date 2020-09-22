using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesApp1.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int CategoryId { get; set; }
        public int Level { get; set; }
        public int Source { get; set; }
        public int Rate { get; set; }

    }
}
