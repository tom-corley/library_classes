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
        public void Library_Constructor_Initialises_With_No_Books()
        {
            Library testLib = new Library();

            Assert.That(testLib.GetAllBooks().Count, Is.Zero);
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

        //[Test]
        //public void AddPatron_Adds_Patron
    }
}