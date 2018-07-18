using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar
{
    public class Course
    {
        public int CourseId { get; set; }

        [StringLength(50)]
        public string CourseName { get; set; }

        [StringLength(10)]
        public string CourseNumber { get; set; }
    }
}