using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public class StudentConsole
    {
        public Student ExecuteAddStudent()
        {
            Student student = new Student();
            Console.WriteLine("Enter student 'Name'");
            var name = Console.ReadLine();
            Console.WriteLine("Enter student 'Surname'");
            var surname = Console.ReadLine();
            student.Name = name;
            student.Surname = surname;
            student.Id = ++Student.IdCounter;
            return student;
        }

        public void ExecuteStudentsList(List<Student> students)
        {
            Console.WriteLine("Studentų yra: "+students.Count);
            foreach (var student in students)
            {
                string mathGrades = String.Join(" ,", student.Grades.mathGrades);
                string biologyGrades = String.Join(" ,", student.Grades.biologyGrades);
                Console.WriteLine($"Student ID: {student.Id}, " +
                    $"Name: {student.Name}," +
                    $"Surname: {student.Surname}," +
                    $"Math grades: {mathGrades}," +
                    $"Biology grades: {biologyGrades}");
            }
        }

        public void ExecuteStudentInfo()
        {
            Console.WriteLine("Plese enter student's Id number");
            var idNumber = Console.ReadLine();
            var studentInfo = students.FirstOrDefault(x => x.Id == idNumber);
        }
    }
}