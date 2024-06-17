using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem.Old
{
    internal class Student
    {
        public string name;
        public int age;
        public List<Course> studyProgram;
        public string studentId;
        int totalCredits;

        public Student(string name, int age, string studentId)
        {
            this.name = name;
            this.age = age;
            studyProgram = new List<Course>();
            this.studentId = studentId;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            //Console.WriteLine("Study program: " + studyProgram);
            Console.WriteLine("Student ID: " + studentId);
        }

        public void PrintCourses()
        {
            Console.WriteLine($"{name}'s courses: ");
            Console.WriteLine();
            foreach (var course in studyProgram)
            {
                Console.WriteLine(course.courseName + ", " + course.courseCode);
                Console.WriteLine("Credits from course: " + course.credits);
                Console.WriteLine();
            }
        }

        public int CalculateTotalCredits()
        {
            foreach (var course in studyProgram)
            {
                totalCredits += course.credits;
            }
            return totalCredits;
        }
    }
}
