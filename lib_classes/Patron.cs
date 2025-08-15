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
        book.Borrow();
        BorrowedBooks.Add(book);
    }

    public void ReturnBook(Book book)
    {
        if (!BorrowedBooks.Contains(book))
        {
            throw new Exception("Attempting to return a book you have not borrowed");
        }
        if (book.IsAvailable)
        {
            throw new Exception("You are trying to return a book that was not checked out");
        }
        book.Return();
        BorrowedBooks.Remove(book);
    }
}