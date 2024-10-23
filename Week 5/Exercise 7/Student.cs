using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    internal class Student
    {
        public string Name { get; set; }
        public int[] Grades { get; set; }

        public Student(string name, int[] grades)
        {
            Name = name;
            Grades = grades;
        }

        public double CalculateAverage()
        {
            int sum = 0;    
            for (int i = 0; i < Grades.Length; i++) 
            {
                sum += Grades[i]; 
            }

            double average = (double)sum / Grades.Length;
            return average;
        }

        public void DisplayGrades()
        {
            Console.WriteLine($"Grades for {Name}:");
            for (int i = 0;i < Grades.Length;i++)
            {
                
                Console.Write($"{Grades[i]}");

                if (i < Grades.Length - 1)
                {
                    Console.Write(",");
                }
            }
        }
    }
}
