using NUnit.Framework.Internal;

namespace lib_classes.Tests
{
    [TestFixture]
    public class LibraryTests
    {
        [Test]
        public void Library_Constructor_Initialises_Non_Null_Object()
        {
            Library testLib = new Library();

            Assert.That(testLib, Is.Not.Null);
        }

        [Test]
        public void Library_Constructor_Initialises_With_No_Books_Or_Patrons()
        {
            Library testLib = new Library();

            Assert.That(testLib.GetAllBooks().Count, Is.Zero);
            Assert.That(testLib.GetAllPatrons().Count, Is.Zero);
        }

        [Test]
        public void AddBook_Adds_Book_To_Library()
        {
            Library testLib = new Library();
            Book testBook = new Book("The Bible", "Larry");
            testLib.AddBook(testBook);

            Assert.That(testLib.GetAllBooks, Does.Contain(testBook));
        }

        [Test]
        public void RemoveBook_Removes_Book_From_Library()
        {
            Library testLib = new Library();
            Book testBook = new Book("The Bible", "Larry");
            testLib.AddBook(testBook);
            testLib.RemoveBook(testBook);

            Assert.That(testLib.GetAllBooks, Does.Not.Contain(testBook));
        }

        [Test]
        public void GetBookByAuthor_Returns_All_Books_By_An_Author()
        {
            Library testLib = new Library();
            Book testBook1 = new Book("The Bible", "Larry");
            Book testBook2 = new Book("The Bible 2", "Larry");
            testLib.AddBook(testBook1);
            testLib.AddBook(testBook2);

            List<Book> res = testLib.GetBookByAuthor("Larry");
            Assert.That(res.Count, Is.EqualTo(2));
            Assert.That(testLib.GetAllBooks, Does.Contain(testBook1));
            Assert.That(testLib.GetAllBooks, Does.Contain(testBook2));
        }

        [Test]
        public void GetBookByTitle_Finds_A_Book()
        {
            Library testLib = new Library();
            Book testBook = new Book("The Bible", "Larry");
            testLib.AddBook(testBook);

            Book res = testLib.GetBookByTitle("The Bible");
            Assert.That(ReferenceEquals(res, testBook));
        }

        [Test]
        public void GetBookByTitle_Throws_For_Book_Not_Found()
        {
            Library testLib = new Library();
            Book testBook = new Book("The Bible", "Larry");
            testLib.AddBook(testBook);

            Assert.Throws<Exception>(() => testLib.GetBookByTitle("Not The Bible"));
        }

        [Test]
        public void AddPatron_Adds_Patron()
        {
            Library testLib = new Library();
            Patron testPatron = new Patron("Dean");
            testLib.AddPatron(testPatron);

            Assert.That(testLib.GetAllPatrons, Does.Contain(testPatron));
        }

        [Test]
        public void RemovePatron_Removes_Patron()
        {
            Library testLib = new Library();
            Patron testPatron = new Patron("Dean");
            testLib.AddPatron(testPatron);
            testLib.RemovePatron(testPatron);

            Assert.That(testLib.GetAllPatrons, Does.Not.Contain(testPatron));
        }

        [Test]
        public void BorrowBook_Refuses_Patron_Not_In_Library()
        {
            Library testLib = new Library();
            Patron testPatron = new Patron("Dean");
            Book testBook = new Book("The Bible", "Larry");
            testLib.AddBook(testBook);

            Assert.Throws<Exception>(() => testLib.BorrowBook(testPatron, testBook));
        }

        [Test]
        public void BorrowBook_Adds_Book_To_Patron_Borrowed()
        {
            Library testLib = new Library();
            Patron testPatron = new Patron("Dean");
            testLib.AddPatron(testPatron);
            Book testBook = new Book("The Bible", "Larry");
            testLib.AddBook(testBook);

            testLib.BorrowBook(testPatron, testBook);

            Assert.That(testPatron.BorrowedBooks, Does.Contain(testBook));
        }

        [Test]
        public void ReturnBook_Removes_Book_From_Patron_Borrowed()
        {
            Library testLib = new Library();
            Patron testPatron = new Patron("Dean");
            testLib.AddPatron(testPatron);
            Book testBook = new Book("The Bible", "Larry");
            testLib.AddBook(testBook);

            testLib.BorrowBook(testPatron, testBook);
            testLib.ReturnBook(testPatron, testBook);

            Assert.That(testPatron.BorrowedBooks, Does.Not.Contain(testBook));
        }

        [Test]
        public void ReturnBook_Refuses_Patron_Not_In_Library()
        {
            Library testLib = new Library();
            Patron testPatron = new Patron("Dean");
            testLib.AddPatron(testPatron);
            Book testBook = new Book("The Bible", "Larry");
            testLib.AddBook(testBook);

            testLib.BorrowBook(testPatron, testBook);
            testLib.RemovePatron(testPatron);

            Assert.Throws<Exception>(() => testLib.ReturnBook(testPatron, testBook));
        }
    }
}