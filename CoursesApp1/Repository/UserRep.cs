using CoursesApp1.Container;
using CoursesApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesApp1.Repository
{
    public class UserRep : IUserRep
    {
        private readonly dbContainer db;

        public UserRep(dbContainer db)
        {
            this.db = db;
        }
        public User AddObj(User obj)
        {
            var data = db.Users.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public User DeleteObj(int Id)
        {
            var olddata = db.Users.Find(Id);
            db.Users.Remove(olddata);
            db.SaveChanges();
            return olddata;
        }

        public User EditObj(User obj)
        {
            var olddata = db.Users.Find(obj.Id);
            olddata.Name = obj.Name;
            olddata.Email = obj.Email;
            olddata.Password = obj.Password;
            //olddata.Level = obj.Level;
            db.SaveChanges();
            return olddata;
        }

        public IEnumerable<User> GetAll()
        {
            var data = db.Users;
            return data;
        }

        public User GetById(int Id)
        {
            var data = db.Users.Find(Id);
            return data;
        }

        public User VlidateUser(string username, string password)
        {
            var data = db.Users.SingleOrDefault(a => a.Name == username && a.Password == password);
            return data;
        }
        public User VlidateEmailForNewUser(string Email)
        {
            var data = db.Users.SingleOrDefault(a => a.Email == Email);
            return data;
        }

    }
}
