using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem.Old
{
    internal class Grade
    {
        public Student student;
        public Course course;
        public int grade;

        public Grade(Student student, Course course, int grade)
        {
            this.student = student;
            this.course = course;
            this.grade = grade;
        }

        //public void PrintInfo()
        //{
        //    Console.WriteLine("Student: " + student.name);
        //    Console.WriteLine("Course: " + course.courseName + ", " + course.courseCode);
        //    Console.WriteLine("Grade: " + grade);
        //}

        //public int ReturnGrade()
        //{
        //    return grade;
        //}

    }
}
