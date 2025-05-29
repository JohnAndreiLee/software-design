using TestPolymorphism;

namespace NUnitTest.Task_2
{
    public class ErrorHandlingTest
    {
        [Test]
        public void TestInvalidMagazine()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Magazine magazine = new Magazine { Title = "Invalid Magazine", Author = "Unknown", IssueNumber = -1 };
            });
            

        }
    }
}
