using System.Text;

public class Patron
{
    public string Name { get; set; }
    public List<Book> BorrowedBooks;

    public Patron(string name)
    {
        Name = name;
        BorrowedBooks = new List<Book>();
    }

    public void BorrowBook(Book book)
    {
        book.Borrow(); // Throws Exception if book is not available
        BorrowedBooks.Add(book);
    }

    public void ReturnBook(Book book)
    {
        if (!BorrowedBooks.Contains(book))
        {
            throw new Exception("Attempting to return a book the patron has not personally borrowed");
        }
        book.Return(); // Throws Exception if book is already available
        BorrowedBooks.Remove(book);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(Name);
        sb.Append($" - Borrowed Books ({BorrowedBooks.Count}):");
        foreach (Book b in BorrowedBooks)
        {
            sb.Append($"\n\t\t{b}");
        }
        return sb.ToString();
    }
}