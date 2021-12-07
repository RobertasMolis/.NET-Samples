using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudentApp
{
    public class StudentConsole
    {
        public Student _student = new Student();

        public void ExecuteAddStudent()
        {
            Console.WriteLine("Enter student 'Name'");
            var name = Console.ReadLine();
            Console.WriteLine("Enter student 'Surname'");
            var surname = Console.ReadLine();

            var Grades
        }

        public void ExecuteStudentsList()
        {

        }

        public void ExecuteStudentInfo()
        {
            Console.WriteLine("Plese enter student's Id number");
            var idNumber = Console.ReadLine();
        }
    }
}
