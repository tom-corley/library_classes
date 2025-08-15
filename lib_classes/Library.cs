using System.Text;

public class Library
{
    private List<Book> Books;
    private List<Patron> Patrons;

    public Library()
    {
        Books = new List<Book>();
        Patrons = new List<Patron>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }

    public List<Book> GetBookByAuthor(string author)
    {
        return Books.Where(b => b.Author == author).ToList();
    }

    public Book GetBookByTitle(string title)
    {
        List<Book> results = Books.Where(b => b.Title == title).ToList();
        if (results.Count > 0)
        {
            return results[0];
        }
        else
        {
            throw new Exception("Book not found");
        }
    }

    public List<Book> GetAllBooks()
    {
        return Books;
    }

    public List<Patron> GetAllPatrons()
    {
        return Patrons;
    }

    public void AddPatron(Patron patron)
    {
        Patrons.Add(patron);
    }

    public void RemovePatron(Patron patron)
    {
        Patrons.Remove(patron);
    }

    public void BorrowBook(Patron patron, Book book)
    {
        if (!Patrons.Contains(patron))
        {
            throw new Exception("Patron is not registered at this library");
        }
        patron.BorrowBook(book); // Exception thrown within here for unavailable book
    }

    public void ReturnBook(Patron patron, Book book)
    {
        if (!Patrons.Contains(patron))
        {
            throw new Exception("Patron is not registered at this library");
        }
        patron.ReturnBook(book); // // Exception thrown within here for available book
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("\n=== LIBRARY ===");
        sb.Append($"\nBooks ({Books.Count}):");
        foreach (Book b in Books)
        {
            sb.Append($"\n\t{b}");
        }
        sb.Append($"\nPatrons ({Patrons.Count}):");
        foreach (Patron p in Patrons)
        {
            sb.Append($"\n\t{p}");
        }
        sb.Append("\n");
        return sb.ToString();
    }
}