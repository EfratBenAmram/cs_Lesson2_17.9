using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson1_10._9
{
    internal class Program
    {
        public static void Students10_9()
        {
            /*
            Student s = new Student("Efrat", 20, "123456789", "chipet");
            s.AddCourse("c");
            s.AddCourse("c++");
            s.AddCourse("c#");
            Console.WriteLine("Details of the new student:");
            s.PrintDetails();
            s.ShowCourses();*/
            List<Student> students = new List<Student> {
                new Student("shira", 19, "67845634", "yu"),
                new Student("dina", 35, "67845634", "uy"),
                new Student("leah", 24, "67847634", "re"),
                new Student("sara", 15, "67845634", "gh")
            };

            Console.WriteLine("Students:");
            foreach (var stu in students)
                stu.PrintDetails();
            Console.WriteLine();

            var upTo20 = students.Where(x => x.Age > 20);
            var sBegin = students.Where(ns => ns.Name.StartsWith("s"));

            Console.WriteLine("Students older than 20:");
            foreach (var stu in upTo20)
                stu.PrintDetails();
            Console.WriteLine();

            
            Console.WriteLine("Students whose names start with 's':");
            foreach (var stu in sBegin)
                stu.PrintDetails(); 
            Console.WriteLine();
        }

        public static void Students17_9()
        {
            /* 1.2.
            Student s1 = new Student("Efrat", 20, "123456789", "chipset");
            s1.AddCourse();
            s1.PrintDetails();
            */

            /* 3. 4. */
            List<Student> students = new List<Student> {
                new Student("shira", 19, "67845634", "yu"),
                new Student("dina", 35, "67845634", "uy"),
                new Student("leah", 24, "67847634", "re")
            };
            foreach (Student stu in students)
            {
                Console.WriteLine("for the dear student " + stu.Name);
                stu.AddCourse();
                Console.WriteLine("\n");
            }
            ShowStudents(students);

            var sBegin = students.Where(ns => ns.Name.StartsWith("s")).ToList();
            var studentsInGroup = students.Where(stu => stu.Group == "yu").ToList();
            var studentsWithMoreThanOneCourse = students.Where(stu => stu.Courses.Count > 1).ToList();
            var studentsWithLowScores = students.Where(stu => stu.Scores.Values.Any(score => score < 56)).ToList();

            Console.WriteLine("Students whose names start with 's':");
            ShowStudents(sBegin);

            Console.WriteLine("Students in the group 'yu':");
            ShowStudents(studentsInGroup);

            Console.WriteLine("Students enrolled in more than one course:");
            ShowStudents(studentsWithMoreThanOneCourse);

            Console.WriteLine("Students with a score less than 56:");
            ShowStudents(studentsWithLowScores);

            Console.ReadLine();
        }

        public static void ShowStudents(List<Student> students)
        {
            foreach (Student stu in students)
            {
                stu.PrintDetails();
                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
            {
            /*
             * 10.9
             * Students10_9();
             */

            /* 
             *  17.9
             */  Students17_9();
             

        }
    }
}
