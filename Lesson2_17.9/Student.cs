using System;
using System.Collections.Generic;

namespace Lesson1_10._9
{
    internal class Student
    {
        private string name;
        private int age;
        private string id;
        private string group;
        //private int cntCourses;
        private List<string> courses;
        private Dictionary<string, int> scores;

        public Student(string name, int age, string id, string group)
        {
            Name = name;
            Group = group;
            Age = age;
            Id = id;
            //cntCourses = 0;
            Courses = new List<string>();
            Scores = new Dictionary<string, int>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 18)
                    age = value;
            }
        }

        public string Id
        {
            get { return id; }
            set
            {
                if (value.Length == 9)
                    id = value;
            }
        }

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        public List<string> Courses
        {
            get { return courses; }
            set { courses = value; }
        }

        public Dictionary<string, int> Scores
        {
            get { return scores; }
            set { scores = value; }
        }

        /*
        public void AddCourse(string course)
        {
            if (cntCourses < 5)
                courses[cntCourses++] = course;
            else
                Console.WriteLine("Courses are full");
        }
        */
        public void AddCourse()
        {
            Console.WriteLine("enter the course and the grade:");
            string course = Console.ReadLine();
            int grade = Int32.Parse(Console.ReadLine());
            while (course != "0") { 
                Courses.Add(course);
                Scores.Add(course, grade);
                Console.WriteLine("enter the course and the grade:");
                course = Console.ReadLine();
                grade = Int32.Parse(Console.ReadLine());
            }
        }

        public void ShowCourses()
        {
            Console.WriteLine("The courses:");
            foreach (string course in Courses)
                if (course != null)
                    Console.WriteLine(course);
        }

        public void ShowScores()
        {
            Console.WriteLine("The scores:");
            foreach (var score in Scores)
            {
                Console.WriteLine("\n\tIn course: " + score.Key);
                Console.WriteLine("\tThe score: " + score.Value);
            }
        }
        /*
         public void ShowCourses()
        {
            Console.WriteLine("The courses:");
            for (int i=0; i<cntCourses; i++)
                if (courses[i] != null)
                    Console.WriteLine(courses[i]);
        }
         */

        public void PrintDetails()
        {
            Console.WriteLine($"Name: Miss. {Name}, Age: {Age}, ID: {Id}, Group: {Group}");
            ShowScores();
        }
    }
}
