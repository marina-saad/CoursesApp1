using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesApp1.Entities
{
    public class Course
    {
        public int Id { get; set; }
       // public string CourseName { get; set; }
        public int CategoryId { get; set; }
        public int LevelId { get; set; }
        public int PlaylistId { get; set; }
        // public String Source { get; set; }
        //public int Rate { get; set; }

        /* [ForeignKey("LevelId")]
         public Level CourseLevel { get; set; }
        
         [ForeignKey("CategoryId")]
         public Category CourseCategory { get; set; }*/

    }
}
