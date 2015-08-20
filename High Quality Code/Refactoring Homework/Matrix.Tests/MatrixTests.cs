namespace Matrix.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Matrix.Logic;

    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GenerateShouldThrowArgumentOutOfRangeExceptionWhenProvidedZero()
        {
            var matrix = Matrix.Generate(0, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GenerateShouldThrowArgumentOutOfRangeExceptionWhenProvidedNegativeData()
        {
            var matrix = Matrix.Generate(-1, -1);
        }

        [TestMethod]
        public void GenerateShouldReturnProperlyBuiltMatrixWhenProvidedCorrectData()
        {
            var matrix = Matrix.Generate(3, 3);
            var expectedMatrix = new int[,]
            {
                {1,7,8},
                {6,2,9},
                {5,4,3}
            };

            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                for (var col = 0; col < matrix.GetLength(1); col++)
                {
                    Assert.AreEqual(expectedMatrix[row,col], matrix[row,col]);
                }
            }
        }
    }
}
