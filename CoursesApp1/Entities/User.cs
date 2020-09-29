using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Threading.Tasks;

namespace CoursesApp1.Entities
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? EnrolledCourseId { get; set; }
        public int? CompletedCourse { get; set; }
        //public int Level { get; set; }

        /*[ForeignKey("EnrolledCourseId")]
        public Course CoursetoBeEnrolledIn { get; set; }*/

    }
}
