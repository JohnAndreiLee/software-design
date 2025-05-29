using TestPolymorphism;

namespace NUnitTest.Task_3
{
    public class StudentChallenge
    {
         [Test]
        public void EdgeCases_BookCreation()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                //Book no title
                Book book = new Book { Title = "", Author = "Unknown"};
                book.GetInfo();

                //Magazine negative issue number
                Magazine magazine = new Magazine { Title = "Error", Author = "Conde Nast", IssueNumber = -146 };

            });

        }
        [Test]
        public void ValidationTest()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var textbook = new Textbook
                {
                    Title = "Differential and Integral Calculus",
                    Author = "Love and Rainville",
                    Subject = ""
                };
            });
        }
    }
}
