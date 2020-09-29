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
    [Route("api/Level/[action]")]
    [ApiController]
    public class LevelServiceController : ControllerBase
    {
        private readonly ILevelRep rep;

        public LevelServiceController(ILevelRep rep)
        {
            this.rep = rep;
        }

        [HttpGet]
        public ActionResult Getalldata()
        {
            var data = rep.GetAll();
            return Ok(data);

        }

        [HttpGet("{LevelId}")]
        public ActionResult GetbyId(int LevelId)
        {
            var data = rep.GetLevelNameByCourseId(LevelId);
            return Ok(data);

        }

        [HttpPost]
        public ActionResult AddCourse(Level obj)
        {
            var data = rep.AddObj(obj);
            return Ok(data);

        }

        [HttpPut]
        public ActionResult putdata(Level obj)
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
