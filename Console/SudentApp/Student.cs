using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudentApp
{
    public class Student
    {
        public int Id { get; set; }
        public int IdCounter { get; set; } = 0;
        public string Name { get; set; }
        public string Surname { get; set; }
        public Grade Grades { get; set; }

        public Student()
        {
            IdCounter++;
            Id = IdCounter;
            Name = Name;
            Surname = Surname;
        }

        public List<Student> Students = new List<Student>();
    }

}
