using CoursesApp1.Container;
using CoursesApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesApp1.Repository
{
    public class CourseRep : ICourseRep
    {
        private readonly dbContainer db;

        public CourseRep(dbContainer db)
        {
            this.db = db;
        }
        public Course AddObj(Course obj)
        {
            var data = db.Courses.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public Course DeleteObj(int Id)
        {
            var olddata = db.Courses.Find(Id);
            db.Courses.Remove(olddata);
            db.SaveChanges();
            return olddata;
        }

        public Course EditObj(Course obj)
        {
            var olddata = db.Courses.Find(obj.Id);
            olddata.PlaylistId = obj.PlaylistId;
            olddata.CategoryId = obj.CategoryId;
            olddata.LevelId = obj.LevelId;
            /*olddata.CourseName = obj.CourseName;
            olddata.CategoryId = obj.CategoryId;
            olddata.Source = obj.Source;
            olddata.Rate = obj.Rate;*/
            db.SaveChanges();
            return obj;
        }

        public IEnumerable<Course> GetAll()
        {
            var data = db.Courses;
            return data;
        }

        public IEnumerable<Course> getallbyCategoryId(int CategoryId)
        {
            var data = db.Courses.Where(a=>a.CategoryId==CategoryId);
            return data;
        }

        public IEnumerable<Course> getallbyLevelId(int LevelId)
        {
            var data = db.Courses.Where(a => a.LevelId == LevelId);
            return data;
        }

        public Course GetById(int Id)
        {
            var data = db.Courses.Find(Id);
            return data;
        }
        public IQueryable<string> GetSourceByCourseId(int CourseId)
        {
            var data = db.Courses.Where(b=>b.Id == CourseId).Select(a=>a.PlaylistId);
            return data;
        }

    }
}
