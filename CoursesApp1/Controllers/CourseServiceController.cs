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
    [Route("api/Course/[action]")]
    [ApiController]
    public class CourseServiceController : ControllerBase
    {
        private readonly ICourseRep rep;

        public CourseServiceController(ICourseRep rep)
        {
            this.rep = rep;
        }

        [HttpGet]
        public ActionResult Getalldata()
        {
            var data = rep.GetAll();
            return Ok(data);

        }

        [HttpGet("{Id}")]
        public ActionResult Getdata(int Id)
        {
            var data = rep.GetById(Id);
            return Ok(data);

        }

        [HttpGet("{categoryId}")]
        public ActionResult GetbyCategoryId(int categoryId)
        {
            var data = rep.getallbyCategoryId(categoryId);
            return Ok(data);
        }

        [HttpGet("{LevelId}")]
        public ActionResult GetbyLevelId(int LevelId)
        {
            var data = rep.getallbyCategoryId(LevelId);
            return Ok(data);
        }

        [HttpGet("{CourseId}")]
        public ActionResult GetSourcebyCourseId(int CourseId)
        {
            var data = rep.GetSourceByCourseId(CourseId);
            return Ok(data);
        }

        [HttpPost]
        public ActionResult AddCourse(Course obj)
        {
            var data = rep.AddObj(obj);
            return Ok(data);

        }

        [HttpPut]
        public ActionResult putdata(Course obj)
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
