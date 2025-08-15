public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        IsAvailable = true;
    }

    public void Borrow()
    {
        if (!IsAvailable)
        {
            throw new Exception("Book is not available");
        }
        IsAvailable = false;
    }

    public void Return()
    {
        IsAvailable = true;
    }
}