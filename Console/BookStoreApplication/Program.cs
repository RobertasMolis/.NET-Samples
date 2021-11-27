using BookStoreApplication.Models;

var books = new List<Books>();

while (true)
{
    Console.WriteLine("Please enter command: 'Add', 'List' or 'Delete'");
    var command = Console.ReadLine();


    if (command == "Add")

    {
        Console.WriteLine("Please enter book title");
        var title = Console.ReadLine();
        bool titleAlreadyExists = books.Any(x => x.Title == title);
        if (titleAlreadyExists == false)
        {
            Console.WriteLine("Please enter description");
            var description = Console.ReadLine();
            Console.WriteLine("Please enter how much books you have");
            var amount = Console.ReadLine();
            
            var amountInput = Convert.ToInt32(amount);
            var book = new Books(title, description, amountInput);
            books.Add(book);
        }
        else if (titleAlreadyExists == true)
        {
            Console.WriteLine("Title you entered already exists");
        }
    }


    else if (command == "Delete")
    {
        Console.WriteLine("Please enter book's Title, Which you want to delete");
        var delete = Console.ReadLine();
        var deleteTitle = books.Single(x => x.Title == delete);
        books.Remove(deleteTitle);


    }

    else if (command == "List")
    {
        foreach (var book in books)
        {
            Console.WriteLine($"Title:{book.Title}, " +
                $"Description:{book.Description}," +
                $"Amount:{book.Amount}");
        }
    }
}