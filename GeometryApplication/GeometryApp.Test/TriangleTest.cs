namespace GeometryApp.Test;
using GeometryApp.Library;
[TestClass]
public class TriangleTest
{
   // Test cases for CalculateArea() for Triangle
        [TestMethod]
        public void CalculateArea_BaseAndHeightProvided_ReturnsCorrectArea()
        {
            Triangle triangle = new Triangle(5, 6, 3, 4, 5);
            var ret = triangle.CalculateArea();
            
            Assert.AreEqual(15, ret);
        }

        [TestMethod]
        public void CalculateArea_BaseOrHeightZero_ThrowsArgumentException()
        {
            Triangle triangle = new Triangle(0, 6, 3, 4, 5);
            Assert.ThrowsException<ArgumentException>(() => triangle.CalculateArea());
        }

        [TestMethod]
        public void CalculateArea_NegativeBaseOrHeight_ThrowsArgumentException()
        {
            Triangle triangle = new Triangle(-5, 6, 3, 4, 5);
            Assert.ThrowsException<ArgumentException>(() => triangle.CalculateArea());
        }

        // Test cases for CalculatePerimeter() for Triangle
        [TestMethod]
        public void CalculatePerimeter_AllSidesPositive_ReturnsCorrectPerimeter()
        {
            Triangle triangle = new Triangle(5, 6, 3, 4, 5);
            double perimeter = triangle.CalculatePerimeter();
            Assert.AreEqual(12, perimeter);
        }

        [TestMethod]
        public void CalculatePerimeter_OneSideZero_ThrowsArgumentException()
        {
            Triangle triangle = new Triangle(5, 6, 0, 4, 5);
            Assert.ThrowsException<ArgumentException>(() => triangle.CalculatePerimeter());
        }

        [TestMethod]
        public void CalculatePerimeter_NegativeSide_ThrowsArgumentException()
        {
            Triangle triangle = new Triangle(5, 6, -3, 4, 5);
            Assert.ThrowsException<ArgumentException>(() => triangle.CalculatePerimeter());
        }
}