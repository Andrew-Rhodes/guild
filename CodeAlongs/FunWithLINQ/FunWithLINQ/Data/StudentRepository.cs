using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunWithLINQ.Models;

namespace FunWithLINQ.Data
{
    public class StudentRepository
    {
        public static List<Student> GetAllStudents()
        {
            return new List<Student>()
            {
                new Student() {
                    ID = 1,
                    FirstName = "Bart",
                    LastName = "Simpson",
                    Gender = "M",
                    Major = "Chemistry"
                },
                new Student()
                {
                    ID = 2,
                    FirstName = "Lisa",
                    LastName = "Simpson",
                    Gender = "F",
                    Major = "Political Science"
                },
                new Student()
                {
                    ID = 3,
                    FirstName = "Bugs",
                    LastName = "Bunny",
                    Gender = "M",
                    Major = "Psychology"
                },
                new Student()
                {
                    ID = 4,
                    FirstName = "Lola",
                    LastName = "Bunny",
                    Gender = "F",
                    Major = "Political Science"
                }
            };
        }

        public static List<StudentCourse> GetAllStudentCourses()
        {
            return new List<StudentCourse>()
            {
                new StudentCourse() {StudentId = 2, CourseName = "Government"},
                new StudentCourse() {StudentId = 2, CourseName = "Math"},
                new StudentCourse() {StudentId = 1, CourseName = "Math"},
                new StudentCourse() {StudentId = 3, CourseName = "Math"},
                new StudentCourse() {StudentId = 4, CourseName = "Math"},
                new StudentCourse() {StudentId = 3, CourseName = "Intro to Programming"}
            };
        }
    }
}
