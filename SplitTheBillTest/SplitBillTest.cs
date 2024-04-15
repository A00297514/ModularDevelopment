using SplitTheBill;
namespace SplitTheBillTest;


[TestClass]
public class SplitBillTest
{
    [TestMethod]
    public void SplitBillTest_Recieves_One_Person_And_Returns_Same_Split_Amount()
    {
        SpiltBill obj = new SpiltBill();
        var ret = obj.SplitTheAmount(15.50m,1);
        Assert.AreEqual(15.50m, ret);
    }

    [TestMethod]
    public void SplitBillTest_Recieves_Multiple_Persons_And_Returns_Equal_Split_Amount()
    {
        SpiltBill obj = new SpiltBill();
        var ret = obj.SplitTheAmount(50.00m,3);
        Assert.AreEqual(16.67m, Math.Round(ret,2));
    }

    [TestMethod]
    public void SplitTheAmount_NegativeAmount_ThrowsArgumentException()
        {
            // Arrange
            SpiltBill billSplitter = new SpiltBill();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => billSplitter.SplitTheAmount(-100.00m, 5));
        }
}