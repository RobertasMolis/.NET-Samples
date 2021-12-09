using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Models;

namespace TodoApp.Services
{
    public class TodoService
    {
        private List<TodoModel> todos = new List<TodoModel>()
        {
            new TodoModel() { Todo = "Walk a dog"},
            new TodoModel() { Todo = "Clean kitchen"}
        };

        public List<TodoModel> GetAll()
        {
            return todos;
        }

        public void Add(TodoModel todoModel)
        {
            todos.Add(todoModel);
            // File.AppendAllText("./data.txt", "{name:petras,description:aprasas}\r\n");
        }
    }
}