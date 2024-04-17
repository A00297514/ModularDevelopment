namespace GeometryApp.Test;
using GeometryApp.Library;
[TestClass]
public class SquareTest
{
    [TestMethod]
    public void Calculate_Area_With_Side_Length_Zero_Throw_Exception()
    {
        Square obj = new Square(0);
        Assert.ThrowsException<ArgumentException>(() => obj.CalculateArea());
    }

    [TestMethod]
    public void Calculate_Area_With_Negative_Side_Length_Throw_Exception()
    {
        Square obj = new Square(-1);
        Assert.ThrowsException<ArgumentException>(() => obj.CalculateArea());
    }

    [TestMethod]
    public void CalculatPerimeter_With_Side_Length_5_Returns_25()
    {
        Square obj = new Square(5);
        var ret = obj.CalculateArea();
        Assert.AreEqual(25, ret);
    }

    [TestMethod]
    public void Calculate_Perimeter_With_Side_Length_Zero_Throw_Exception()
    {
        Square obj = new Square(0);
        Assert.ThrowsException<ArgumentException>(() => obj.CalculatePerimeter());
    }

    [TestMethod]
    public void Calculate_Perimeter_With_Negative_Side_Length_Throw_Exception()
    {
        Square obj = new Square(-1);
        Assert.ThrowsException<ArgumentException>(() => obj.CalculatePerimeter());
    }
    
    [TestMethod]
    public void CalculatPerimeter_With_Side_Length_5_Returns_20()
    {
        Square obj = new Square(5);
        var ret = obj.CalculatePerimeter();
        Assert.AreEqual(20, ret);
    }
}