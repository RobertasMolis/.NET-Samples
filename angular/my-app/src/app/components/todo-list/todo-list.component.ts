import { Component, OnInit } from '@angular/core';
import { TodosService } from 'src/app/services/todos.service';
import Todo from 'src/app/models/todo.model';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.scss']
})
export class TodoListComponent implements OnInit {

  constructor(private todoService: TodosService) { }

  public todos: Todo[] =[
    {
      id: 1,
      title: 'Bandymas'
    }
  ]

  ngOnInit(): void {
    this.todoService.getAllTodos().subscribe((todos) => {
      this.todos = todos;
    });
  }
}
