using CMP1976_Test.MathLib;
namespace CMP1976_Test.MathLibTest;

[TestClass]
public class Calculator_Divide
{
    [TestMethod]
   public void Calculator_Divide_Recieves_A_Number_And_One_Then_Retruns_Number()
   {
        Calculator calculator = new Calculator();
        var ret = calculator.Divide(4,1);
        Assert.AreEqual(4, ret);
   }

   [TestMethod]
   [DataRow(1,1,1)]
   [DataRow(2,2,1)]
   public void Calculator_Divide_Recieves_Two_Of_The_Same_Numbers_Then_Retruns_One(double dividend, double divisor, double expected)
   {
        Calculator calculator = new Calculator();
        var ret = calculator.Divide((decimal)dividend,(decimal)divisor);
        Assert.AreEqual((decimal)expected, ret);
   }

   [TestMethod]
   public void Calculator_Divide_Recieves_A_Number_And_Zero_Then_Retruns_Exception()
   {
        Calculator calculator = new Calculator();

        Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(0,0));
   }
}