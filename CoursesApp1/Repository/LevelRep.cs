using CoursesApp1.Container;
using CoursesApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesApp1.Repository
{
    public class LevelRep : ILevelRep
    {
        private readonly dbContainer db;

        public LevelRep(dbContainer db)
        {
            this.db = db;
        }
        public Level AddObj(Level obj)
        {
            var data = db.Levels.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public Level DeleteObj(int Id)
        {
            var olddata = db.Levels.Find(Id);
            db.Levels.Remove(olddata);
            db.SaveChanges();
            return olddata;
        }

        public Level EditObj(Level obj)
        {
            var olddata = db.Levels.Find(obj.Id);
            olddata.LName = obj.LName;
            db.SaveChanges();
            return obj;
        }

        public IEnumerable<Level> GetAll()
        {
            var data = db.Levels;
            return data;
        }

        public Level GetById(int Id)
        {
            var data = db.Levels.Find(Id);
            return data;
        }

        public IQueryable<string> GetLevelNameByCourseId(int LevelId)
        {
            var data = db.Levels.Where(b => b.Id == LevelId).Select(a => a.LName);
            return data;
        }
    }
}
