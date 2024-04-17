using SplitTheBill;
namespace SplitTheBillTest;


[TestClass]
public class SplitBillTest
{
    [TestMethod]
    public void SplitBillTest_Recieves_One_Person_And_Returns_Same_Split_Amount()
    {
        //Arrange
        SpiltBill obj = new SpiltBill();
        //Act
        var ret = obj.SplitTheAmount(15.50m,1);
        //Assert
        Assert.AreEqual(15.50m, ret);
    }

    [TestMethod]
    public void SplitBillTest_Recieves_Multiple_Persons_And_Returns_Equal_Split_Amount()
    {
        //Arrange
        SpiltBill obj = new SpiltBill();
        //Act
        var ret = obj.SplitTheAmount(50.00m,3);
        //Assert
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


    // Test method for calculating tip per person when price, patrons, and tip percentage are valid.
    [TestMethod]
    public void CalculateTipPerPerson_ValidInputs_ReturnsCorrectTipPerPerson()
    {
        // Arrange
        decimal price = 100.00m;
        int patrons = 4;
        float tipPercentage = 15.0f;
        
        SpiltBill obj = new SpiltBill();

        // Act
        decimal actualTipPerPerson =  obj.CalculateTipPerPerson(price, patrons, tipPercentage);

        // Assert
        Assert.AreEqual(3.75m, actualTipPerPerson);
    }

    // Test method for handling zero price input.
    [TestMethod]
    public void CalculateTipPerPerson_ZeroPrice_ThrowsArgumentException()
    {
        // Arrange
        decimal price = 0.00m;
        int patrons = 2;
        float tipPercentage = 10.0f;
        SpiltBill obj = new SpiltBill();
        // Assert
        Assert.ThrowsException<ArgumentException>(() => obj.CalculateTipPerPerson(price, patrons, tipPercentage));
    }

    // Test method for handling negative patrons input.
    [TestMethod]
    public void CalculateTipPerPerson_NegativePatrons_ThrowsArgumentException()
    {
        // Arrange
        decimal price = 50.00m;
        int patrons = -1;
        float tipPercentage = 10.0f;
        SpiltBill obj = new SpiltBill();

        // Assert
        Assert.ThrowsException<ArgumentException>(() => obj.CalculateTipPerPerson(price, patrons, tipPercentage));
    }

    // Test method for handling negative tip percentage input.
    [TestMethod]
    public void CalculateTipPerPerson_NegativeTipPercentage_ThrowsArgumentException()
    {
        // Arrange
        decimal price = 75.00m;
        int patrons = 3;
        float tipPercentage = -5.0f;
        SpiltBill obj = new SpiltBill();

        // Assert
        Assert.ThrowsException<ArgumentException>(() => obj.CalculateTipPerPerson(price, patrons, tipPercentage));
    }

}