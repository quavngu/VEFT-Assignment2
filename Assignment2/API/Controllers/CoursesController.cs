using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment2.Models;
using Assignment2.Services;

namespace Assignment2.API.Controllers
{
    [Route("api/courses")]
    public class CoursesController : Controller
    {
        private readonly ICoursesService _service;

        public CoursesController(ICoursesService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<CourseLiteDTO> GetCoursesOnSemester(string semester) 
        {
            if(semester == null) 
            {
                return _service.GetCoursesBySemester("20163");
            }
            else 
            {
                return _service.GetCoursesBySemester(semester);
            }
        }
    }
}