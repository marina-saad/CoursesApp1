using CoursesApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesApp1.Repository
{
    interface ICategoryRep
    {
        IEnumerable<Category> GetAll();
        Category GetById(int Id);

        Category AddObj(Category obj);

        Category EditObj(Category obj);

        Category DeleteObj(int Id);
    }
}
