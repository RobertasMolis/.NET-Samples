using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Models;

namespace TodoApp.Services
{
    public class TodoService
    {
        private List<TodoModel> Todos = new List<TodoModel>()
        {
            new TodoModel() { Todo = "Walk a dog"},
            new TodoModel() {Todo = "Clean kitchen"}
        };

        public List<TodoModel> GetAll()
        {
            return Todos;
        }

        public void Add(TodoModel todoModel)
        {
            Todos.Add(todoModel);
        }
    }
}
