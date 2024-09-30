using GradeBook.Console;

namespace GradeBook.Tests
{
    [TestClass]
    public class GradeBookTest
    {
        [TestMethod]
        public void CalculateHighestGrade()
        {
            GradeBookModel book = new GradeBookModel();
            book.AddGrade(90f);
            book.AddGrade(50f);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(90f, stats.HighestGrade);
        }

        [TestMethod]
        public void PassByValue()
        {
            GradeBookModel book = new GradeBookModel();
            book.Name = "Not set";
            SetName(book);

            Assert.AreEqual("Name setted", book.Name);
        }

        void SetName(GradeBookModel book)
        {
            book.Name = "Name setted";
        }

        //[TestMethod]
        //public void TestMethod1()
        //{
        //    bool value = true;
        //    Assert.IsTrue(value);
        //}
    }
}