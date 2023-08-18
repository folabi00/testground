using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestUniversity.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public int Credits { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public string Title { get; set; }
          
    }
}