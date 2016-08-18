using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FunWithLINQ.Data;
using FunWithLINQ.Models;

namespace FunWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            AnonymousTypes();
            Joins();
            GroupBy();

            Console.ReadLine();
        }

        static void AnonymousTypes()
        {
            Console.WriteLine("<= Anonymous Types");

            // getting our data from our repository
            // This is something we will see from here on out... 
            List<Student> students = StudentRepository.GetAllStudents();

            // QUERY SYNTAX
            //var ladies = from s in students
            //    where s.Gender == "F"
            //    select new
            //    {
            //        Name = $"{s.FirstName} {s.LastName}",
            //        s.Major
            //    };

            // METHOD SYNTAX
            var ladies =
                students.Where(s => s.Gender == "F").Select(x => new {Name = $"{x.FirstName} {x.LastName}", x.Major});

            // using var because the type of collection is an anonymous type
            // can't say anything but var
            foreach (var lady in ladies)
            {
                Console.WriteLine($"{lady.Name} is majoring in {lady.Major}");
            }

            Console.WriteLine();
        }

        static void Joins()
        {
            Console.WriteLine("<= Joins");

            List<Student> students = StudentRepository.GetAllStudents();
            List<StudentCourse> courses = StudentRepository.GetAllStudentCourses();

            // join the student to the course the student is taking

            // QUERY SYNTAX
            //var results = from s in students
            //    join c in courses
            //        on s.ID equals c.StudentId
            //    select new
            //    {
            //        c.CourseName,
            //        StudentName = $"{s.FirstName} {s.LastName}"
            //    };

            // METHOD SYNTAX
            var results = students.Join(courses, student => student.ID, course => course.StudentId,
                (student, course) => new
                {
                    course.CourseName,
                    StudentName = $"{student.FirstName} {student.LastName}"
                });

            foreach (var result in results)
            {
                Console.WriteLine($"{result.StudentName} is taking {result.CourseName}");
            }

            Console.WriteLine();
        }

        static void GroupBy()
        {
            Console.WriteLine("<= GroupBy");

            var students = StudentRepository.GetAllStudents();

            // QUERY SYNTAX
            // TAKE is demonstrating mixed syntax
            var results = (from s in students
                          where s.Major != "Chemistry"
                          orderby s.Major descending, s.LastName
                          group s by s.Major).Take(2);

            // METHOD SYNTAX
            //var results = students.Where(student => student.Major != "Chemistry")
            //    .OrderByDescending(s => s.Major)
            //    .ThenBy(s => s.LastName)
            //    .GroupBy(student => student.Major);

            foreach (var group in results)
            {
                Console.WriteLine(group.Key);

                foreach (var student in group)
                {
                    Console.WriteLine($"\t{student.FirstName} {student.LastName} - {student.Major}");
                }
            }

            Console.WriteLine();
        }
    }
}
