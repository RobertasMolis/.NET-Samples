using BookStoreApplication.Models;

var books = new List<Books>();

while (true)
{
    Console.WriteLine("Please enter command: 'Add', 'List', 'Update' or 'Delete'");
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

    if (command.ToLower() == "delete")
    {
        Console.WriteLine("Please enter book's Title, which you want to delete");
        var delete = Console.ReadLine();
        var deleteTitle = books.Single(x => x.Title == delete);
        books.Remove(deleteTitle);
    }

    if (command.ToLower() == "update")
    {
        Console.WriteLine("Enter Title which you want to update");
        var update = Console.ReadLine();
        var updateBook = books.FirstOrDefault(x => x.Title == update);
        bool titleExists = books.Any(x => x.Title == update);
        if (titleExists == false)
        {
            Console.WriteLine("There is no such book");
        }
        if (titleExists == true)
        {
            Console.WriteLine("Enter new Title");
            if (updateBook != null) updateBook.Title = Console.ReadLine();
            Console.WriteLine("Enter new Description");
            if (updateBook != null) updateBook.Description = Console.ReadLine();
            Console.WriteLine("Enter new Amount");
            if (updateBook != null) updateBook.Amount = Convert.ToInt32(Console.ReadLine());
        }
    }


    if (command.ToLower() == "list")
    {
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, " +
                $"Description: {book.Description}, " +
                $"Amount:{book.Amount}");
        }
    }
}