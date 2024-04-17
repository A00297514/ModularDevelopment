namespace GeometryApp.Test;
using GeometryApp.Library;
[TestClass]
public class RectangleTest
{
    // Test cases for CalculateArea() for Rectangle
    [TestMethod]
    public void Calculate_Area_With_Length_And_Width_Zero_Throw_Exception()
    {
        Rectangle obj = new Rectangle(0,0);
        Assert.ThrowsException<ArgumentException>(() => obj.CalculateArea());
    }

    [TestMethod]
    public void Calculate_Area_With_Negative_Length_And_Positive_Width_Throw_Exception()
    {
        Rectangle obj = new Rectangle(-1,5);
        Assert.ThrowsException<ArgumentException>(() => obj.CalculateArea());
    }

    [TestMethod]
    public void Calculate_Area_With_Length_5_And_Width_4_Returns_20()
    {
        Rectangle obj = new Rectangle(5,4);
        var ret = obj.CalculateArea();
        Assert.AreEqual(20, ret);
    }

    // Test cases for CalculatePerimeter() for Rectangle
   [TestMethod]
    public void Calculate_Perimeter_With_Length_And_Width_Zero_Throw_Exception()
    {
        Rectangle obj = new Rectangle(0,0);
        Assert.ThrowsException<ArgumentException>(() => obj.CalculatePerimeter());
    }

    [TestMethod]
    public void Calculate_Perimeter_With_Negative_Length_And_Positive_Width_Throw_Exception()
    {
        Rectangle obj = new Rectangle(-1,5);
        Assert.ThrowsException<ArgumentException>(() => obj.CalculatePerimeter());
    }

    [TestMethod]
    public void Calculate_Perimeter_With_Length_5_And_Width_4_Returns_18()
    {
        Rectangle obj = new Rectangle(5,4);
        var ret = obj.CalculatePerimeter();
        Assert.AreEqual(18, ret);
    }
}