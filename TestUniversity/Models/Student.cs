using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestUniversity.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required(ErrorMessage ="Last Name Required")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "First Mid Name Required")]
        [DisplayName("First Mid Name")]
        public string FirstMidName { get; set; }
       // [Required(ErrorMessage = "Enrollment Date Required")]
        public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}