using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem.Old
{
    internal class StudentAdministrasjonssystem
    {

        public void Run()
        {
            List<Course> courses = new List<Course>
            {
                new Course("PL_0154", "Plumbing", 150),
                new Course("PAC_0137", "Pasta cooking", 120),
                new Course("KS_0121", "Koopa stomping", 220),
            };

            var plumbing = courses[0];
            var cooking = courses[1];

            List<Student> students = new List<Student>
            {
                new Student("Mario", 32, "001"),
                new Student("Luigi", 30, "002"),
            };

            var mario = students[0];
            var luigi = students[1];

            foreach(Course course in courses)
            {
                mario.studyProgram.Add(course);
                luigi.studyProgram.Add(course);
            }

            List<Grade> grades_Mario = new List<Grade>
            {
                new Grade(mario, plumbing, 4),
                new Grade(mario, cooking, 5),
            };


            List<Grade> grades_Luigi = new List<Grade>
            {
                new Grade(luigi, plumbing, 5),
                new Grade(luigi, cooking, 6),
            };

            var plumbingGradeMario = grades_Mario[0];
            var cookingGradeMario = grades_Mario[1];

            var plumbingGradeLuigi = grades_Luigi[0];
            var cookingGradeLuigi = grades_Luigi[1];

            foreach(Student student in students)
            {
                PrintEverything(student, courses);
                Console.WriteLine();
            }
        }

        public void PrintStudent(Student student)
        {
            student.PrintInfo();
        }


        public void PrintEverything(Student student, List<Course> courses)
        {
            PrintStudent(student);
            Console.WriteLine();
            student.PrintCourses();
            Console.WriteLine();
            printCourses(courses);
            Console.WriteLine("Credits sum total: " + student.CalculateTotalCredits());
        }

        public void printCourses(List<Course> courses)
        {
            foreach (var item in courses)
            {
                Console.WriteLine(item.courseName);
            }
        }
    }
}
