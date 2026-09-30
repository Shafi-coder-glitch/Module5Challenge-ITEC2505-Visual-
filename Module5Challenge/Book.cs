// Defines the Book class and stores information about a book.
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    // Creates a new book with a title, author, and ISBN.
    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

    // Returns the book information as text.
    public override string ToString()
    {
        return $"{Title} by {Author} (ISBN: {ISBN})";
    }
}