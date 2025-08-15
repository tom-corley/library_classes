public class Program
{
    public static void Main(string[] args)
    {
        // Example Code to create a library with 3 books and add two patrons

        // Creating Library Object
        Library myLibrary = new Library();

        // Creatinng three books and adding them to the library
        Book the_hobbit = new Book("The Hobbit", "J.R.R. Tolkien");
        Book nineteen_eighty_four = new Book("1984", "George Orwell");
        Book hunger_games = new Book("The Hunger Games", "Suzanne Collins");
        myLibrary.AddBook(the_hobbit);
        myLibrary.AddBook(nineteen_eighty_four);
        myLibrary.AddBook(hunger_games);

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

    }
}