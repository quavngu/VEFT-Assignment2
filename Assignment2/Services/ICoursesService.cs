using System;
using System.Collections.Generic;
using Assignment2.Models;

namespace Assignment2.Services
{
    public interface ICoursesService
    {
        List<CourseLiteDTO> GetCoursesBySemester(string semester);
    }
}
