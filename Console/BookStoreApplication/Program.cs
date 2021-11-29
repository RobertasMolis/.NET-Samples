using BookStoreApplication.Models;

var books = new List<Books>();

while (true)
{
    Console.WriteLine("Please enter command: 'Add', 'List' or 'Delete'");
    var command = Console.ReadLine();


    if (command.ToLower() == "add")

    {
        Console.WriteLine("Please enter book title");
        var title = Console.ReadLine();
        bool titleAlreadyExists = books.Any(x => x.Title == title);
        if (titleAlreadyExists == false)
        {
            Console.WriteLine("Please enter description");
            var description = Console.ReadLine();
            Console.WriteLine("Please enter how much books you have");
            var amount = 0;
            try
            {
                amount = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter number");
                amount = Convert.ToInt32(Console.ReadLine());
            }

            var book = new Books(title, description, amount);
            books.Add(book);
        }
        else if (titleAlreadyExists == true)
        {
            Console.WriteLine("Title you entered already exists." +
                " Please enter another one");
        }
    }

    else if (command.ToLower() == "delete")
    {
        Console.WriteLine("Please enter book's Title, which you want to delete");
        var delete = Console.ReadLine();
        var deleteTitle = books.Single(x => x.Title == delete);
        books.Remove(deleteTitle);
    }

    else if (command.ToLower() == "list")
    {
        foreach (var book in books)
        {
            Console.WriteLine($"Title:{book.Title}, " +
                $"Description:{book.Description}," +
                $"Amount:{book.Amount}");
        }
    }
}