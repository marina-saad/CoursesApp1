using CoursesApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesApp1.Repository
{
    public interface IUserRep
    {
        IEnumerable<User> GetAll();
        User GetById(int Id);
        User GetByEmail(string Email);

        User AddObj(User obj);

        User EditObj(User obj);

        User DeleteObj(int Id);

        User VlidateUser(string username, string password);
        User VlidateEmailForNewUser(string Email);

    }
}
