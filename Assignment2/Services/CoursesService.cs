using System;
using System.Linq;
using System.Collections.Generic;
using Assignment2.Models;

namespace Assignment2.Services
{
    public class CoursesService : ICoursesService
    {
        private readonly AppDataContext _db;

        public CoursesService(AppDataContext db)
        {
            _db = db;
        }

        public List<CourseLiteDTO> GetCoursesBySemester(string semester)
        {
            var courses = _db.Courses
                .Where(x => x.Semester == semester)
                .OrderBy(x => x.Name)
                .Select(x => new CourseLiteDTO{
                    ID = x.ID,
                    Name = x.Name,
                    Semester = x.Semester
                })
                .ToList();

            return courses;

            /*return (from x in _db.Courses
                    select new CourseLiteDTO 
                    {
                        ID = x.ID,
                        Name = x.Name,
                        Semester = x.Semester
                    }).ToList();*/
        }
    }
}
