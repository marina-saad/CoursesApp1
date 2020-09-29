using CoursesApp1.Container;
using CoursesApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesApp1.Repository
{
    public class CategoryRep : ICategoryRep
    {
        private readonly dbContainer db;

        public CategoryRep(dbContainer db)
        {
            this.db = db;
        }
       
        public Category AddObj(Category obj)
        {
            var data = db.Categories.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public Category DeleteObj(int Id)
        {
            var olddata = db.Categories.Find(Id);
            db.Categories.Remove(olddata);
            db.SaveChanges();
            return olddata;
        }

        public Category EditObj(Category obj)
        {
            var olddata = db.Categories.Find(obj.Id);
            olddata.CategoryName = obj.CategoryName;
            db.SaveChanges();
            return obj;
        }

        public IEnumerable<Category> GetAll()
        {
            var data = db.Categories;
            return data;
        }

        public Category GetById(int Id)
        {
            var data = db.Categories.Find(Id);
            return data;
        }
        public IQueryable<string> GetCategoryNameByCourseId(int CategoryId)
        {
            var data = db.Categories.Where(b => b.Id == CategoryId).Select(a => a.CategoryName);
            return data;
        }
    }
}
