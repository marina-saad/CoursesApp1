using CoursesApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesApp1.Repository
{
    interface ICourseRep
    {
        IEnumerable<Course> GetAll();
        Course GetById(int Id);

        Course AddObj(Course obj);

        Course EditObj(Course obj);

        Course DeleteObj(int Id);
    }
}
