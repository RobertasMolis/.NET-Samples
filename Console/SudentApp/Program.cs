using SudentApp;

var studentConsole = new StudentConsole();

while (true)
{
    Console.WriteLine("Please enter command: 'AddStudent', 'StudentsList' or 'StudentInfo'");

    var command = Console.ReadLine();

    if (command == "AddStudent")
    {
        studentConsole.ExecuteAddStudent();
    }
    else if (command == "StudentList")
    {
        studentConsole.ExecuteStudentsList();
    }
    else if (command == "StudentInfo")
    {
        studentConsole.ExecuteStudentInfo();
    }
}

