using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        ///Book constructor, initialize the field.
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        ///Add grade method.
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        ///Show Statitistics method.
        public void ShowStatistics()
        {
             // var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
            // grades.Add(56.1);

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }
            

            result /= grades.Count;
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {result:N1}");
        }

        ///Field grades.
        private List<double> grades; 

        ///Field name.
        private string name; 
    }
}