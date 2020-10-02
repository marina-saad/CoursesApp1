using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoursesApp1.Entities;
using CoursesApp1.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursesApp1.Controllers
{
    [Route("api/User/[action]")]
    [ApiController]
    public class UserServiceController : ControllerBase
    {
        private readonly IUserRep rep;

        public UserServiceController(IUserRep rep)
        {
            this.rep = rep;
        }

        [HttpGet]
        public ActionResult Getalldata()
        {
            var data = rep.GetAll();
            return Ok(data);

        }
        [HttpGet("{Email}")]
        public ActionResult GetUserByEmail(string Email)
        {
            var user = rep.GetByEmail(Email);

            return Ok(user);


        }

        [HttpGet("{Email}/{Password}")]
        public ActionResult Login(string Email, String Password)
        {
            var user = rep.VlidateUser(Email, Password);

            if (user != null)
            {
                //Redirect()
                return Ok(true);
            }
            else
            {
                return NotFound(false);
            }
        }


        [HttpPost]
        //[AllowAnonymous]
        //do we need to make model for mapping from the android to database 
        public ActionResult Signup(User Newone)
        {
            var user = rep.VlidateEmailForNewUser(Newone.Email);

            if (user != null)
            {
                //already exist 
                return NotFound(false);
            }
            else
            {
                var data = rep.AddObj(Newone);
                return Ok(data);
            }
        }


        [HttpPut]
        public ActionResult putdata(User obj)
        {
            var data = rep.EditObj(obj);
            return Ok(data);

        }

        [HttpDelete("{Id}")]
        public ActionResult deletedata(int Id)
        {
            var data = rep.DeleteObj(Id);
            return Ok(data);

        }



    }
}
