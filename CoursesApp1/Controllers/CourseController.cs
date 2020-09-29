using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CoursesApp1.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoursesApp1.Controllers
{
    public class CourseController : Controller
    {
        //http://localhost:50051/
        public IActionResult Index()
        {
            HttpClient htp = new HttpClient();
            htp.BaseAddress = new Uri("http://localhost:50051/");

            var res = htp.GetAsync("api/Course").Result;

            var content = res.Content.ReadAsStringAsync().Result;

            var data = JsonConvert.DeserializeObject<IEnumerable<Course>>(content);
            return View(data);
        }
    }
}
