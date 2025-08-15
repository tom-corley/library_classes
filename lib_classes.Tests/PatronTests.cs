namespace lib_classes.Tests
{
    [TestFixture]
    public class PatronTests
    {
        [Test]
        public void Patron_Constructor_Sets_Name()
        {
            Patron testPatron = new Patron("Dean");
            Assert.That(testPatron.Name, Is.EqualTo("Dean"));
        }

        [Test]
        public void Patron_Constructor_Initialises_Empty_Borrow_List()
        {
            Patron testPatron = new Patron("Dean");
            Assert.That(testPatron.BorrowedBooks, Is.Not.Null);
            Assert.That(testPatron.BorrowedBooks.Count, Is.EqualTo(0));
        }

        [Test]
        public void BorrowBook_Adds_Book_To_Borrowed_Books()
        {
            Patron testPatron = new Patron("Dean");
            Book testBook = new Book("The Bible", "Larry");
            testPatron.BorrowBook(testBook);
            Assert.That(testPatron.BorrowedBooks.Count, Is.EqualTo(1));
            Assert.That(testPatron.BorrowedBooks, Does.Contain(testBook));
        }

        [Test]
        public void ReturnBook_Removes_Book_From_Borrowed_Books()
        {
            Patron testPatron = new Patron("Dean");
            Book testBook = new Book("The Bible", "Larry");
            testPatron.BorrowBook(testBook);
            testPatron.ReturnBook(testBook);
            Assert.That(testPatron.BorrowedBooks.Count, Is.EqualTo(0));
            Assert.That(testPatron.BorrowedBooks, Does.Not.Contain(testBook));
        }

        [Test]
        public void ReturnBook_Throws_When_Returning_Book_Patron_Has_Not_Borrowed()
        {
            Patron testPatron = new Patron("Dean");
            Book testBook = new Book("The Bible", "Larry");
            Assert.Throws<Exception>(() => testPatron.ReturnBook(testBook));
        }

        [Test]
        public void Patron_Converts_To_String_Correctly()
        {
            Patron testPatron = new Patron("Dean");
            Book testBook = new Book("The Bible", "Larry");
            testPatron.BorrowBook(testBook);

            string res = testPatron.ToString();

            Assert.That(res, Is.EqualTo("Dean - Borrowed Books (1):\n\t\tThe Bible - Larry"));
        }
    }
}