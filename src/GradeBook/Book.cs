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

        ///Field grades.
        private List<double> grades; 

        ///Field name.
        private string name; 
    }
}