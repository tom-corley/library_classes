public class Program
{
    public static void Main(string[] args)
    {
        // Example Code to create a library with 3 books and add two patrons

        // Creating Library Object
        Library myLibrary = new Library();

        // Creating three books and adding them to the library
        Book the_hobbit = new Book("The Hobbit", "J.R.R. Tolkien");
        Book nineteen_eighty_four = new Book("1984", "George Orwell");
        Book hunger_games = new Book("The Hunger Games", "Suzanne Collins");
        myLibrary.AddBook(the_hobbit);
        myLibrary.AddBook(nineteen_eighty_four);
        myLibrary.AddBook(hunger_games);
        System.Console.WriteLine(myLibrary);

        // New Patrons Dan and Tony
        Patron dan = new Patron("Dan");
        Patron tony = new Patron("Tony");
        myLibrary.AddPatron(dan);
        myLibrary.AddPatron(tony);

        // Dan borrows "The Hobbit" and returns it
        myLibrary.BorrowBook(dan, the_hobbit);
        myLibrary.ReturnBook(dan, the_hobbit);

        // Tony borrows "1984"", fails to return it and is then removed as a Patron
        myLibrary.BorrowBook(tony, nineteen_eighty_four);
        myLibrary.RemovePatron(tony);
        System.Console.WriteLine(tony);

        // Dan, trying to be a good samaritan, returns 1984 for Tony, this is not allowed
        try
        {
            myLibrary.ReturnBook(dan, nineteen_eighty_four);
        }
        catch (Exception e)
        {
            System.Console.WriteLine($"Exception: {e.Message}");
        }

        // Dan forgets that he has already returned the hobbit,
        // since he no longer has it checked out, this throws an exception.
        try
        {
            myLibrary.ReturnBook(dan, the_hobbit);
        }
        catch (Exception e)
        {
            System.Console.WriteLine($"Exception: {e.Message}");
        }

        // Business has been pretty poor, so they decide to let Tony back in, 
        // he immediately borrows the Hunger Games, without even returning 1984
        // Dan tries to borrow it too seconds later...
        myLibrary.AddPatron(tony);
        myLibrary.BorrowBook(tony, hunger_games);
        try
        {
            myLibrary.BorrowBook(dan, hunger_games);
        }
        catch (Exception e)
        {
            System.Console.WriteLine($"Exception: {e.Message}");
        }
        System.Console.WriteLine(myLibrary);

        // Dan wants "The Bible", but cannot find a copy
        try
        {
            myLibrary.BorrowBook(dan, myLibrary.GetBookByTitle("The Bible"));
        }
        catch (Exception e)
        {
            System.Console.WriteLine($"Exception: {e.Message}");
        }
    }
}