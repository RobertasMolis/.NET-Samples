using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public static int IdCounter { get; set; } = 0;
        public string Name { get; set; }
        public string Surname { get; set; }
        public Grade Grades { get; set; }

        public Student()
        {
            Id = IdCounter++;
            Grades = new Grade(); 
            Grades.mathGrades.Add(1);
            Grades.biologyGrades.Add(7);
        }
    }
}
