public class Program
{
    public static void Main(string[] args)
    {
        // Example Code to create a library with 3 books and add two patrons
        Library myLibrary = new Library();

        Book the_hobbit = new Book("The Hobbit", "J.R.R. Tolkien");
        Book nineteen_eighty_four = new Book("1984", "George Orwell");
        Book hunger_games = new Book("The Hunger Games", "Suzanne Collins");
        myLibrary.AddBook(the_hobbit);
        myLibrary.AddBook(nineteen_eighty_four);
        myLibrary.AddBook(hunger_games);

        Patron dan = new Patron("Dan");
        Patron tony = new Patron("Tony");
        myLibrary.AddPatron(dan);
        myLibrary.AddPatron(tony);
    }
}