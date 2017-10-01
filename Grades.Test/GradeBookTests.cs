﻿using System;
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

        [TestMethod]
        public void ComputesLowestGrade()
        {
            //-- Arrange
            GradeBook book = new GradeBook();

            book.AddGrade(10);
            book.AddGrade(90);

            //-- Act
            GradeStatistics result = book.ComputeStatistics();

            //-- Assert
            Assert.AreEqual(10, result.LowestGrade);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            //-- Arrange
            GradeBook book = new GradeBook();

            book.AddGrade(grade: 91F);
            book.AddGrade(grade: 89.5F);
            book.AddGrade(grade: 75F);

            //-- Act
            GradeStatistics result = book.ComputeStatistics();

            //-- Assert
            Assert.AreEqual(85.16, result.AverageGrade, 0.01);
        }
    }
}
