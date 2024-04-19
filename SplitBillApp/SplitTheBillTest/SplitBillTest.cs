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
//-------------------------------------------------------------------------------------------------------------------------------------
    // Test case: Calculate tip for empty meal costs dictionary
    [TestMethod]
    public void Test_EmptyMealCostsDictonary_Throws_Exception()
    {
        // Arrange
        Dictionary<string, decimal> mealCosts = new Dictionary<string, decimal>();
        float tipPercentage = 15.00f;
        SpiltBill billSplitter = new SpiltBill();
        
        
        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() => billSplitter.CalculateTip(mealCosts, tipPercentage));
    }

    // Test case: Calculate tip for non-empty meal costs dictionary with negative tip percentage (should throw ArgumentException)
    [TestMethod]
    public void Test_NonEmptyMealCosts_But_NegativeTipPercentage_ThrowsException()
    {
        // Arrange
        Dictionary<string, decimal> mealCosts = new Dictionary<string, decimal>()
        {
            { "Sagar", 40.25M },
            { "Meet", 22.75M }
        };
        float tipPercentage = -5;
        SpiltBill billSplitter = new SpiltBill();

        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() => billSplitter.CalculateTip(mealCosts, tipPercentage));
    }

    // Test case: Calculate tip for non-empty meal costs dictionary with positive tip percentage
    [TestMethod]
    public void Test_NonEmptyMealCosts_ZeroTipPercentage_Returns_Dictonary_With_Weighted_Avg_Tip()
    {

        // Arrange
        SpiltBill billSplitter = new SpiltBill();
        Dictionary<string, decimal> mealCosts = new Dictionary<string, decimal>()
        {
            { "Sagar", 50M },
            { "Milan", 30M }
        };
        float tipPercentage = 0f;
        
        // Act
        var ret = billSplitter.CalculateTip(mealCosts, tipPercentage);
        Dictionary<string, decimal> expect  = new Dictionary<string, decimal>()
        {
            { "Sagar", 0M },
            { "Milan", 0M }
        };

        CollectionAssert.AreEqual(expect,ret);    
    }




//-----------------------------------------------------------------------------------------------------------------------------------

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