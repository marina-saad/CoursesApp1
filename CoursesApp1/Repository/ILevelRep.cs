using CoursesApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesApp1.Repository
{
    public interface ILevelRep
    {
        IEnumerable<Level> GetAll();
        Level GetById(int Id);

        Level AddObj(Level obj);

        Level EditObj(Level obj);

        Level DeleteObj(int Id);
        IQueryable<string> GetLevelNameByCourseId(int Id);
    }
}
