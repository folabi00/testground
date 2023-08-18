using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TestUniversity.Models;

namespace TestUniversity.DAL
{
    public class SchoolInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student { FirstMidName="Victor", LastName="Afolabi", EnrollmentDate= DateTime.Parse("2009-10-09") },
                new Student { FirstMidName="Alexander", LastName="King", EnrollmentDate= DateTime.Parse("2009-10-09") },
                new Student { FirstMidName="Ayomide", LastName="Olaoye", EnrollmentDate= DateTime.Parse("2009-10-10") },
                new Student { FirstMidName="Joshua", LastName="Anderson", EnrollmentDate= DateTime.Parse("2009-10-09") },
                new Student { FirstMidName="Adeoye", LastName="John", EnrollmentDate= DateTime.Parse("2009-11-09") },
                new Student { FirstMidName="Simisola", LastName="Adesanya", EnrollmentDate= DateTime.Parse("2009-10-09") },
                new Student { FirstMidName="Joshua", LastName="Anderson", EnrollmentDate= DateTime.Parse("2009-10-09") },
                new Student { FirstMidName="Adekunle", LastName="Adedire", EnrollmentDate= DateTime.Parse("2009-10-11") },

            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course { Title ="Microbiology", Credits = 3},
                new Course { Title ="Chemistry", Credits = 3},
                new Course { Title ="Economics", Credits = 3},
                new Course { Title ="Trigonometry", Credits = 4},
                new Course { Title ="Biology", Credits = 3},
                new Course { Title ="Language", Credits = 4},
                new Course { Title ="Physics", Credits = 3},
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment {StudentID = 1, CourseID = 1, Grade = 1 },
                new Enrollment {StudentID = 1, CourseID = 2, Grade = 3 },
                new Enrollment {StudentID = 1, CourseID = 3, Grade = 1 },
                new Enrollment {StudentID = 2, CourseID = 4, Grade = 2 },
                new Enrollment {StudentID = 2, CourseID = 5, Grade = 4 },
                new Enrollment {StudentID = 2, CourseID = 6, Grade = 4 },
                new Enrollment {StudentID = 3, CourseID = 1, Grade = 1 },
                new Enrollment {StudentID = 3, CourseID = 2, Grade = 3 },
                new Enrollment {StudentID = 3, CourseID = 3, Grade = 2 },
                new Enrollment {StudentID = 4, CourseID = 1,           },
                new Enrollment {StudentID = 4, CourseID = 2, Grade = 4 },
                new Enrollment {StudentID = 5, CourseID = 1, Grade = 3 },
                new Enrollment {StudentID = 5, CourseID = 2, Grade = 1 },
                new Enrollment {StudentID = 5, CourseID = 3, Grade = 2 },
                new Enrollment {StudentID = 6, CourseID = 1, Grade = 1 },
                new Enrollment {StudentID = 6, CourseID = 2, Grade = 3 },
                new Enrollment {StudentID = 6, CourseID = 3, Grade = 4 },
                new Enrollment {StudentID = 7, CourseID = 1, Grade = 2 },
                new Enrollment {StudentID = 7, CourseID = 2, Grade = 3 },
                new Enrollment {StudentID = 7, CourseID = 3, Grade = 1 },
                new Enrollment {StudentID = 8, CourseID = 1, Grade = 1 },
                new Enrollment {StudentID = 8, CourseID = 2, Grade = 4 },

            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}