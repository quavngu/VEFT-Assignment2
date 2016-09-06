using System;

namespace Assignment2.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CourseLiteDTO
    {
        /// <summary>
        /// Database-generated ID of the course
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The name of the course.
        /// Example: "Web Services"
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Example: 20163 -> Fall 2016
        /// </summary>
        public string Semester { get; set; }
    }
}
