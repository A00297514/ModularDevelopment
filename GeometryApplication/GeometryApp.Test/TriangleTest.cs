namespace GeometryApp.Test;
using GeometryApp.Library;
[TestClass]
public class TriangleTest
{
   // Test cases for CalculateArea() for Triangle
        [TestMethod]
        public void CalculateArea_BaseAndHeightProvided_ReturnsCorrectArea()
        {
            // Arrange
            Triangle triangle = new Triangle(5, 6, 3, 4, 5);
            // Act
            var ret = triangle.CalculateArea();
            // Assert
            Assert.AreEqual(15, ret);
        }

        [TestMethod]
        public void CalculateArea_BaseOrHeightZero_ThrowsArgumentException()
        {
            // Arrange
            Triangle triangle = new Triangle(0, 6, 3, 4, 5);
            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => triangle.CalculateArea());
        }

        [TestMethod]
        public void CalculateArea_NegativeBaseOrHeight_ThrowsArgumentException()
        {
            // Arrange
            Triangle triangle = new Triangle(-5, 6, 3, 4, 5);
            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => triangle.CalculateArea());
        }

        // Test cases for CalculatePerimeter() for Triangle
        [TestMethod]
        public void CalculatePerimeter_AllSidesPositive_ReturnsCorrectPerimeter()
        {
            // Arrange
            Triangle triangle = new Triangle(5, 6, 3, 4, 5);
            // Act
            double perimeter = triangle.CalculatePerimeter();
            // Assert
            Assert.AreEqual(12, perimeter);
        }

        [TestMethod]
        public void CalculatePerimeter_OneSideZero_ThrowsArgumentException()
        {
            // Arrange
            Triangle triangle = new Triangle(5, 6, 0, 4, 5);
            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => triangle.CalculatePerimeter());
        }

        [TestMethod]
        public void CalculatePerimeter_NegativeSide_ThrowsArgumentException()
        {
            // Arrange
            Triangle triangle = new Triangle(5, 6, -3, 4, 5);
            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => triangle.CalculatePerimeter());
        }
}