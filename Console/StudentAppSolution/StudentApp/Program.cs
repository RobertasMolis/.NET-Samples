using StudentApp;
using StudentApp.Models;

var studentConsole = new StudentConsole();
List<Student> students = new List<Student>();

while (true)
{
    Console.WriteLine("Please enter command: 'AddStudent', 'StudentList' or 'StudentInfo'");

    var command = Console.ReadLine();

    if (command == "AddStudent")
    {
        students.Add(studentConsole.ExecuteAddStudent());
    }
    else if (command == "StudentList")
    {
        studentConsole.ExecuteStudentsList(students);
    }
    else if (command == "StudentInfo")
    {
        studentConsole.ExecuteStudentInfo();
    }
}

