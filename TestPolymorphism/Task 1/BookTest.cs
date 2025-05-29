//using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestPolymorphism
{
    [TestFixture]
    public class BookTest
    {
        [Test]
        public void TestTextBookCreation()
        {
            Book book = new Book { Title = "The C Programming Language", Author = "Brian Kernighan" };
            Assert.That("The C Programming Language", Is.EqualTo(book.Title));
            Assert.That("Brian Kernighan", Is.EqualTo(book.Author));
        }
        [Test]
        public void TestMagazineCreation()
        {
            Magazine magazine = new Magazine { Title = "Wired", Author = "Conde Nast", IssueNumber = 146 };
            Assert.That("Wired", Is.EqualTo(magazine.Title));
            Assert.That(146, Is.EqualTo(magazine.IssueNumber));
        }
    }
}