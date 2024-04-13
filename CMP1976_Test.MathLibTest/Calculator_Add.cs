using CMP1976_Test.MathLib;
namespace CMP1976_Test.MathLibTest;

[TestClass]
public class Calculator_Add
{
    [TestMethod]
    public void Calculator_Add_Recieves_Two_Zeros_And_Returns_Zero()
    {
        Calculator calculator = new Calculator();
        var ret = calculator.Add(0, 0);
        Assert.AreEqual(0, ret);
    }

[TestMethod]
    public void Calculator_Add_Recieves_A_One_And_A_Zeros_And_Returns_One()
    {
        Calculator calculator = new Calculator();
        var ret = calculator.Add(1, 0);
        Assert.AreEqual(1, ret);
    }
}