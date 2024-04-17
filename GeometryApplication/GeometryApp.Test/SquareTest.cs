namespace GeometryApp.Test;
using GeometryApp.Library;
[TestClass]
public class SquareTest
{
    // Test cases for CalculateArea() of Square
    [TestMethod]
    public void Calculate_Area_With_Side_Length_Zero_Throw_Exception()
    {
        // Arrange
        Square obj = new Square(0);
        // Act and Assert
        Assert.ThrowsException<ArgumentException>(() => obj.CalculateArea());
    }

    [TestMethod]
    public void Calculate_Area_With_Negative_Side_Length_Throw_Exception()
    {
        // Arrange
        Square obj = new Square(-1);
        // Act and Assert
        Assert.ThrowsException<ArgumentException>(() => obj.CalculateArea());
    }

    [TestMethod]
    public void Calculate_Area_With_Side_Length_5_Returns_25()
    {
        // Arrange
        Square obj = new Square(5);
        // Act
        var ret = obj.CalculateArea();
        // Assert
        Assert.AreEqual(25, ret);
    }

    // Test cases for CalculatePerimeter() for Square

    [TestMethod]
    public void Calculate_Perimeter_With_Side_Length_Zero_Throw_Exception()
    {
        // Arrange
        Square obj = new Square(0);
        // Act and Assert
        Assert.ThrowsException<ArgumentException>(() => obj.CalculatePerimeter());
    }

    [TestMethod]
    public void Calculate_Perimeter_With_Negative_Side_Length_Throw_Exception()
    {
        // Arrange
        Square obj = new Square(-1);
        // Act and Assert
        Assert.ThrowsException<ArgumentException>(() => obj.CalculatePerimeter());
    }
    
    [TestMethod]
    public void CalculatPerimeter_With_Side_Length_5_Returns_20()
    {
        // Arrange
        Square obj = new Square(5);
        // Act
        var ret = obj.CalculatePerimeter();
        //Assert
        Assert.AreEqual(20, ret);
    }
}