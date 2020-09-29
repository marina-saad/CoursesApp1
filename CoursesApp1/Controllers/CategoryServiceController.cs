using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoursesApp1.Entities;
using CoursesApp1.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursesApp1.Controllers
{
    [Route("api/Category/[action]")]
    [ApiController]
    public class CategoryServiceController : ControllerBase
    {
        private readonly ICategoryRep rep;

        public CategoryServiceController( ICategoryRep rep)
        {
            this.rep = rep;
        }

        [HttpGet]
        public ActionResult Getalldata()
        {
            var data = rep.GetAll();
            return Ok(data);

        }
        /*[HttpGet("{Id}")]
        public ActionResult GetdatabyId(int Id)
        {
            var data = rep.GetById(Id);
            return Ok(data);

        }*/
        [HttpGet("{CategoryId}")]
        public ActionResult GetbyId(int CategoryId)
        {
            var data = rep.GetCategoryNameByCourseId(CategoryId);
            return Ok(data);

        }

        [HttpPost]
        public ActionResult AddCourse(Category obj)
        {
            var data = rep.AddObj(obj);
            return Ok(data);

        }

        [HttpPut]
        public ActionResult putdata(Category obj)
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
