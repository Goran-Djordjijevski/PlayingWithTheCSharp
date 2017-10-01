using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Test
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            //-- Arrange
            GradeBook book = new GradeBook();

            book.AddGrade(10);
            book.AddGrade(90);

            //-- Act
            GradeStatistics result = book.ComputeStatistics();

            //-- Assert
            Assert.AreEqual(90, result.HighestGrade);
        }
    }
}
