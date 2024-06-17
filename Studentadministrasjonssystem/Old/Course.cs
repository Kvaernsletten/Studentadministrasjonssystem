using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem.Old
{
    internal class Course
    {

        public string courseCode;
        public string courseName;
        public int credits;

        public Course(string courseCode, string courseName, int credits)
        {
            this.courseCode = courseCode;
            this.courseName = courseName;
            this.credits = credits;
        }

        //public void PrintInfo()
        //{
        //    Console.WriteLine("Course name: " + courseName);
        //    Console.WriteLine("Course code: " + courseCode);
        //    Console.WriteLine("Total study points from course: " + credits);
        //}
    }
}
