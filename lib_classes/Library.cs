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
        patron.BorrowBook(book);
    }

    public void ReturnBook(Patron patron, Book book)
    {
        patron.ReturnBook(book);
    }
}