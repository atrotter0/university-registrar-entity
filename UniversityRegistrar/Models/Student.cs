using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar
{
    public class Student
    {
        public int StudentId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(75)]
        public string LastName { get; set; }
    }
}