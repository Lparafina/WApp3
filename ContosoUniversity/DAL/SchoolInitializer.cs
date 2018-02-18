using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FGF.Models;

namespace FGF.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Event>
            {
            new Event{CourseID=1050,Title="Chemistry",Credits=3,},
            new Event{CourseID=4022,Title="Microeconomics",Credits=3,},
            new Event{CourseID=4041,Title="Macroeconomics",Credits=3,},
            new Event{CourseID=1045,Title="Calculus",Credits=4,},
            new Event{CourseID=3141,Title="Trigonometry",Credits=4,},
            new Event{CourseID=2021,Title="Composition",Credits=3,},
            new Event{CourseID=2042,Title="Literature",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Register>
            {
            new Register{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Register{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Register{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Register{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Register{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Register{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Register{StudentID=3,CourseID=1050},
            new Register{StudentID=4,CourseID=1050,},
            new Register{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Register{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Register{StudentID=6,CourseID=1045},
            new Register{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}