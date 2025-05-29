namespace TestPolymorphism
{
   
    [TestFixture]
    public class PolymorphismTest
    {
        [Test]
        public void TestPolymorphism()
        {
            Book[] books = new Book[]
            {
                new Book { Title = "Neuromancer", Author = "William Gibson" },
                new Magazine { Title = "Wired", Author = "Conde Nast", IssueNumber = 146 },
                new Ebook { Title = "All Tomorrows", Author = "Cevdet Mehmet Kösemen", SizeMB = 37 }
            };

            Assert.That(books[0].GetInfo(), Is.EqualTo("Neuromancer by William Gibson"));
            Assert.That(books[1].GetInfo(), Is.EqualTo("Wired by Conde Nast - Issue: 146"));
            Assert.That(books[2].GetInfo(), Is.EqualTo("All Tomorrows by Cevdet Mehmet Kösemen - Size: 37MB"));
        }
    }
}
