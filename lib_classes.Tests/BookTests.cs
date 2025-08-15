namespace lib_classes.Tests
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void Book_Constructor_Sets_Title()
        {
            Book testBook = new Book("The Bible", "Larry");

            Assert.That(testBook.Title, Is.EqualTo("The Bible"));
        }

        [Test]
        public void Book_Constructor_Sets_Author()
        {
            Book testBook = new Book("The Bible", "Larry");

            Assert.That(testBook.Author, Is.EqualTo("Larry"));
        }
        
        [Test]
        public void Book_Constructor_Sets_Available()
        {
            Book testBook = new Book("The Bible", "Larry");

            Assert.That(testBook.IsAvailable, Is.True);
        }
        [Test]
        public void Borrow_Throws_If_Unavailable()
        {
            Book testBook = new Book("The Bible", "Larry");

            testBook.Borrow();
            Assert.Throws<Exception>(testBook.Borrow);
        }

        [Test]
        public void Borrow_Sets_Unavailable()
        {
            Book testBook = new Book("The Bible", "Larry");

            testBook.Borrow();
            Assert.That(testBook.IsAvailable, Is.False);
        }

        [Test]
        public void Return_Sets_Available()
        {
            Book testBook = new Book("The Bible", "Larry");

            testBook.Borrow();
            testBook.Return();
            Assert.That(testBook.IsAvailable, Is.True);
        }
    }
}