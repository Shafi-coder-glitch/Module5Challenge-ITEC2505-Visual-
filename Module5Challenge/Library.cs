using System;
using System.Collections.Generic;
using System.Linq;

// Defines the Library class and manages the books in the library.
public class Library
{
    public string Name { get; set; }
    private List<Book> Books { get; set; }

    // Creates a library with a name and an empty book list.
    public Library(string name)
    {
        Name = name;
        Books = new List<Book>();
    }

    // Adds a book to the library.
    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Added: {book}");
    }

    // Removes a book from the library using its ISBN.
    public bool RemoveBook(string isbn)
    {
        Book bookToRemove = Books.FirstOrDefault(b => b.ISBN == isbn);
        if (bookToRemove != null)
        {
            Books.Remove(bookToRemove);
            Console.WriteLine($"Removed: {bookToRemove}");
            return true;
        }
        Console.WriteLine("Book not found.");
        return false;
    }

    // Displays all books currently available in the library.
    public void DisplayAvailableBooks()
    {
        Console.WriteLine("Available Books:");
        foreach (var book in Books)
        {
            Console.WriteLine(book);
        }
    }

    // Finds and returns a book using its ISBN.
    public Book GetBook(string isbn)
    {
        return Books.FirstOrDefault(b => b.ISBN == isbn);
    }
}
